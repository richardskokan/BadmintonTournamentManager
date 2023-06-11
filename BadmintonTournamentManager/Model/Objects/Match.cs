using BadmintonTournamentManager.Model.Common;
using BadmintonTournamentManager.Model.Helpers;
using System.Text;

namespace BadmintonTournamentManager.Model.Objects
{
    public class Match : ISaveable
    {
        public long Id { get; set; }

        public long TournamentId { get; set; } = -1;

        public string Name { get; set; } = "";
        public string VenueCourt { get; set; } = "";
        public DateTime? StartTime { get; set; }
        public Game[] Games { get; set; } = new Game[3];

        public MatchStatusEnum Status { get; private set; }

        public long Player1Id { get; set; } = -1;
        public long Player2Id { get; set; } = -1;

        public long PreviousMatch1Id { get; set; } = -1;
        public long PreviousMatch2Id { get; set; } = -1;

        public Match() { }
         
        public Match(long id)
        {
            Id = id;
        }

        public string GetStartTimeString()
        {
            return $"{StartTime:d\\. M\\. yyyy HH:mm}";
        }

        public string GetGameListScores()
        {
            var result = new StringBuilder();

            for (int i = 0; i < Games.Length; i++)
            {
                if (Games[i] == null)
                    result.Append("-:-");
                else
                    result.Append(Games[i].GetScoreString());

                if (i < Games.Length - 1)
                    result.Append(", ");
            }

            return result.ToString();
        }

        public bool UpdateMatchStatus()
        {
            var oldStatus = Status;

            if (StartTime > DateTime.Now)
                Status = MatchStatusEnum.SCHEDULED;
            else if (GetWinner() == -1)
                Status = MatchStatusEnum.PLAYING;
            else
                Status = MatchStatusEnum.ENDED;

            return oldStatus != Status;
        }

        public (int, int) GetPlayerScores()
        {
            int player1Score = 0;
            int player2Score = 0;

            foreach (Game? game in Games)
            {
                if (game == null)
                    break;

                switch (game.GetWinner())
                {
                    case GameWinnerEnum.PLAYER_ONE:
                        player1Score++; break;
                    case GameWinnerEnum.PLAYER_TWO:
                        player2Score++; break;
                    case GameWinnerEnum.UNDETERMINED:
                        continue;
                }
            }

            return (player1Score, player2Score);
        }

        public long GetWinner()
        {
            (int player1Score, int player2Score) = GetPlayerScores();

            if (player1Score > player2Score)
                return Player1Id;
            if (player1Score < player2Score)
                return Player2Id;
            return -1;
        }

        public void AddGame(int player1Score, int player2Score)
        {
            for (int i = 0; i < Games.Length; i++)
            {
                if (Games[i] == null)
                {
                    Games[i] = new Game(player1Score, player2Score);
                    return;
                }
            }

            throw new InvalidOperationException($"A match can not have more than {Games.Length} games");
        }

        public (int, int) GetGamesStats(Player player)
        {
            int gamesWon = 0;
            int gamesLost = 0;

            foreach(Game game in Games)
            {
                if (game == null)
                    break;

                if (player.Id == Player1Id && game.ScorePlayer1 > game.ScorePlayer2
                    || player.Id == Player2Id && game.ScorePlayer2 > game.ScorePlayer1)
                    gamesWon++;
                else
                    gamesLost++;
            }

            return (gamesWon, gamesLost);
        }
    }
}
