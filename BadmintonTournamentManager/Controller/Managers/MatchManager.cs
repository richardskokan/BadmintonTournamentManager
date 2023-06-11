using BadmintonTournamentManager.Model.Helpers;
using BadmintonTournamentManager.Model.Objects;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.Controller.Managers
{
    public class MatchManager
    {
        private AppContext AppContext;

        public HashSet<Match> Matches { get; private set; }

        public MatchManager(AppContext appContext, HashSet<Match> data)
        {
            AppContext = appContext;
            Matches = data;
        }

        public void UpdateMatchSet(IEnumerable<Match> data)
        {
            foreach (var match in data)
                Matches.Add(match);
        }

        public Match FindMatch(long matchId)
        {
            var match = Matches.FirstOrDefault(m => m.Id == matchId);
            ValueCheckHelper.CheckObjectExists(match, "match");

            return match!;
        }

        private long GetNewId()
        {
            return Matches.Count == 0 ? 1 : Matches.Max(x => x.Id) + 1;
        }

        public IEnumerable<Match> FindAllMatchesWithId(IEnumerable<long> ids)
        {
            return Matches.Where(m => ids.Contains(m.Id));
        }

        public Match CreateMatch(Tournament tournament, string name, string venueCourt, DateTime startTime)
        {
            var match = new Match(GetNewId());

            match.TournamentId = tournament.Id;

            ValueCheckHelper.CheckString(name, "name");
            match.Name = name;

            ValueCheckHelper.CheckString(venueCourt, "court name");
            match.VenueCourt = venueCourt;

            ValueCheckHelper.CheckDateInRange(startTime, tournament.DateStart, tournament.DateEnd);
            match.StartTime = startTime;

            match.UpdateMatchStatus();

            tournament.AddMatch(match);

            UpdatePlayerStats(match);

            Matches.Add(match);
            return match;
        }

        public bool ManageMatch(Match match, string? name, string? venueCourt, DateTime? startTime)
        {
            if (name != null)
            {
                ValueCheckHelper.CheckString(name, "name");
                match.Name = name;
            }

            if (venueCourt != null)
            {
                ValueCheckHelper.CheckString(venueCourt, "court name");
                match.VenueCourt = venueCourt;
            }

            if (startTime != null)
            {
                var tournament = AppContext.Tournaments.FindTournament(match.TournamentId);
                ValueCheckHelper.CheckDateInRange((DateTime)startTime, tournament.DateStart, tournament.DateEnd);
                match.StartTime = (DateTime)startTime;
            }

            if (match.UpdateMatchStatus())
                UpdatePlayerStats(match);

            return true;
        }

        public bool ManageMatch(long matchId, string? name, string? venueCourt, DateTime? startTime)
        {
            return ManageMatch(FindMatch(matchId), name, venueCourt, startTime);
        }

        public bool DeleteMatch(AppContext appContext, Match match)
        {
            var tournament = appContext.Tournaments.FindTournament(match.TournamentId);
            if (tournament != null)
                appContext.Tournaments.RemoveMatchFromTournament(tournament, match);

            return Matches.Remove(match);
        }

        public bool DeleteMatch(AppContext appContext, long matchId)
        {
            return DeleteMatch(appContext, FindMatch(matchId));
        }

        public bool AddPlayer1ToMatch(Match match, Player player)
        {
            if (match.Player2Id == player.Id)
                return false;

            if (match.Player1Id != -1 && match.Player1Id == player.Id)
                return true;

            match.Player1Id = player.Id;
            match.PreviousMatch1Id = -1;

            return true;
        }

        public bool AddPlayer1ToMatch(long matchId, Player player)
        {
            return AddPlayer1ToMatch(FindMatch(matchId), player);
        }

        public bool AddPlayer2ToMatch(Match match, Player player)
        {
            if (match.Player1Id == player.Id)
                return false;

            if (match.Player2Id != -1 && match.Player2Id == player.Id)
                return true;

            match.Player2Id = player.Id;
            match.PreviousMatch2Id = -1;

            return true;
        }

        public bool AddPlayer2ToMatch(long matchId, Player player)
        {
            return AddPlayer2ToMatch(FindMatch(matchId), player);
        }

        public bool AddPreviousMatch1ToMatch(Match match, Match previousMatch)
        {
            if (previousMatch.Id == match.PreviousMatch2Id)
                return false;

            if (match.PreviousMatch1Id != -1 && match.PreviousMatch1Id == previousMatch.Id)
                return true;

            match.PreviousMatch1Id = previousMatch.Id;
            match.Player1Id = previousMatch.GetWinner();

            return true;
        }

        public bool AddPreviousMatch1ToMatch(long matchId, Match previousMatch)
        {
            return AddPreviousMatch1ToMatch(FindMatch(matchId), previousMatch);
        }

        public bool AddPreviousMatch2ToMatch(Match match, Match previousMatch)
        {
            if (previousMatch.Id == match.PreviousMatch1Id)
                return false;

            if (match.PreviousMatch2Id != -1 && match.PreviousMatch2Id == previousMatch.Id)
                return true;

            match.PreviousMatch2Id = previousMatch.Id;
            match.Player2Id = previousMatch.GetWinner();

            return true;
        }

        public bool AddPreviousMatch2ToMatch(long matchId, Match previousMatch)
        {
            return AddPreviousMatch2ToMatch(FindMatch(matchId), previousMatch);
        }

        public void UpdatePlayerStats(Match match)
        {
            if (match.Status != MatchStatusEnum.ENDED)
                return;

            AppContext.Players.UpdatePlayerStatistics(match.Player1Id, match);
            AppContext.Players.UpdatePlayerStatistics(match.Player2Id, match);
        }
    }
}
