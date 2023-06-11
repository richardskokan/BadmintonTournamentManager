using BadmintonTournamentManager.Controller.Filesystem;
using BadmintonTournamentManager.Controller.Helpers;
using BadmintonTournamentManager.Model.Objects;
using System.Text;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.Controller.Common
{
    public class MatchTreeGenerator
    {
        private const string LINE_SPLIT = " ─┬─ ";
        private const string LINE_DOWN = "  │  ";
        private const string LINE_CORNER = "  └─ ";
        private const string LINE_EMPTY = "     ";
        private const string MATCH_NAME_EMPTY = "               ";

        private AppContext AppContext;

        public MatchTreeGenerator(AppContext appContext)
        {
            AppContext = appContext;
        }

        public async void GenerateMatchTree(Match lastMatch)
        {
            var result = new StringBuilder();

            // Delay for demonstration purposes
            // await Task.Delay(5000);

            await GenerateMatchTreeStringAsync(lastMatch, new List<string>(), result);

            string fileName = $"match-tree-{DateTime.Now:dMyyyyHHmmss}.txt";
            string filePath = Path.Combine(Paths.MatchTreeFolderPath, fileName);
            FileHelper.WriteToFileAsync(filePath, result.ToString());
        }

        private async Task GenerateMatchTreeStringAsync(Match lastMatch, List<string> lineList, StringBuilder builder, bool firstMatch = true)
        {
            var winnerId = lastMatch.GetWinner();
            if (winnerId != -1)
            {
                var winner = AppContext.Players.FindPlayer(winnerId);
                builder.Append($"{winner.GetFullName(),15}");
            }
            else
            {
                builder.Append($"{lastMatch.Name,15}");
            }
            

            builder.Append(LINE_SPLIT);

            if(lineList.Count == 0)
            {
                lineList.Add(LINE_CORNER);
            }
            else
            {
                lineList.Add(LINE_CORNER);
                lineList[lineList.Count - 2] = (firstMatch ? LINE_DOWN : LINE_EMPTY);
            }

            await ContinueLegAsync(builder, lineList, lastMatch.Player1Id, lastMatch.PreviousMatch1Id, true);
            
            builder.AppendLine();
            ProcessLineList(lineList, builder);

            await ContinueLegAsync(builder, lineList, lastMatch.Player2Id, lastMatch.PreviousMatch2Id, false);

            LowerOffset(lineList);
        }

        private async Task ContinueLegAsync(StringBuilder builder, List<string> lineList, long playerId, long matchId, bool firstMach)
        {
            if (playerId != -1)
            {
                builder.Append($"{AppContext.Players.FindPlayer(playerId).GetFullName(),15}");
            }
            else if (matchId != -1)
            {
                var match = AppContext.Matches.FindMatch(matchId);
                await GenerateMatchTreeStringAsync(match, lineList, builder, firstMach);
            }
            else
            {
                // should not be able to happen
                builder.Append(MATCH_NAME_EMPTY);
            }
        }

        private void ProcessLineList(List<string> lineList, StringBuilder builder)
        {
            foreach (string line in lineList)
            {
                builder.Append(MATCH_NAME_EMPTY);
                builder.Append(line);
            }
        }

        private void LowerOffset(List<string> lineList)
        {
            if (lineList.Count == 0)
                return;

            Stack<string> stack = new();
            stack.Push(lineList[lineList.Count - 1]);

            bool skippedSpaces = false;

            for (int i = lineList.Count - 2; i > 0; i--)
            {
                if (!skippedSpaces && lineList[i].Equals(LINE_EMPTY))
                {
                    continue;
                }
                else
                {
                    skippedSpaces = true;
                    stack.Push(lineList[i]);
                }
            }

            lineList.Clear();
            while (stack.Count > 0)
            {
                lineList.Add(stack.Pop());
            }
        }
    }
}
