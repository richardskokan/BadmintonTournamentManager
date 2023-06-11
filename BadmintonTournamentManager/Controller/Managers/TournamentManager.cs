using BadmintonTournamentManager.Model.Helpers;
using BadmintonTournamentManager.Model.Objects;
using System.Numerics;

namespace BadmintonTournamentManager.Controller.Managers
{
    public class TournamentManager
    {
        public HashSet<Tournament> Tournaments { get; private set; }

        public TournamentManager(HashSet<Tournament> data)
        {
            Tournaments = data;
        }

        public void UpdateTournamentSet(IEnumerable<Tournament> data)
        {
            foreach (var tournament in data)
                Tournaments.Add(tournament);
        }

        private long GetNewId()
        {
            return Tournaments.Count == 0 ? 1 : Tournaments.Max(x => x.Id) + 1;
        }

        public Tournament FindTournament(long tournamentId)
        {
            var tournament = Tournaments.FirstOrDefault(t => t.Id == tournamentId);
            ValueCheckHelper.CheckObjectExists(tournament, "tournament");

            return tournament!;
        }

        public Tournament CreateTournament(string name, string venue, DateTime dateStart, DateTime dateEnd)
        {
            var tournament = new Tournament(GetNewId());

            ValueCheckHelper.CheckString(name, "tournament name");
            tournament.Name = name;

            ValueCheckHelper.CheckString(venue, "venue name");
            tournament.Venue = venue;

            ValueCheckHelper.CheckDateSuccession(dateStart, dateEnd);
            tournament.DateStart = dateStart;
            tournament.DateEnd = dateEnd;

            Tournaments.Add(tournament);
            return tournament;
        }

        public bool ManageTournament(Tournament tournament, string? name, string? venue, DateTime? dateStart, DateTime? dateEnd)
        {
            if (name != null)
            {
                ValueCheckHelper.CheckString(name, "tournament name");
                tournament.Name = name;
            }

            if (venue != null)
            {
                ValueCheckHelper.CheckString(venue, "venue name");
                tournament.Venue = venue;
            }

            if (dateStart != null && dateEnd != null)
            {
                ValueCheckHelper.CheckDateSuccession(dateStart, dateEnd);
                tournament.DateStart = (DateTime)dateStart;
                tournament.DateEnd = (DateTime)dateEnd;
            }
            else if (dateStart != null)
            {
                ValueCheckHelper.CheckDateSuccession(dateStart, tournament.DateEnd);
                tournament.DateStart = (DateTime)dateStart;
            }
            else if (dateEnd != null)
            {
                ValueCheckHelper.CheckDateSuccession(tournament.DateStart, dateEnd);
                tournament.DateEnd = (DateTime)dateEnd;
            }

            return true;
        }

        public bool ManageTournament(long tournamentId, string? name, string? venue, DateTime? dateStart, DateTime? dateEnd)
        {
            return ManageTournament(FindTournament(tournamentId), name, venue, dateStart, dateEnd);
        }

        public bool RemoveTournament(Tournament tournament)
        {
            return Tournaments.Remove(tournament);
        }

        public bool RemoveTournament(long tournamentId)
        {
            return RemoveTournament(FindTournament(tournamentId));
        }

        public bool RegisterPlayerInTournament(Tournament tournament, Player player)
        {
            return tournament.AddPlayer(player);
        }

        public bool RegisterPlayerInTournament(long tournamentId, Player player)
        {
            return RegisterPlayerInTournament(FindTournament(tournamentId), player);
        }

        public bool RemovePlayerFromTournament(Tournament tournament, Player player)
        {
            return tournament.RemovePlayer(player);
        }

        public bool RemovePlayerFromTournament(long tournamentId, Player player)
        {
            return RemovePlayerFromTournament(FindTournament(tournamentId), player);
        }

        public bool AddMatchToTournament(Tournament tournament, Match match)
        {
            match.TournamentId = tournament.Id;

            return tournament.AddMatch(match);
        }

        public bool AddMatchToTournament(long tournamentId, Match match)
        {
            return AddMatchToTournament(FindTournament(tournamentId), match);
        }

        public bool RemoveMatchFromTournament(Tournament tournament, Match match)
        {
            match.TournamentId = -1;
            return tournament.RemoveMatch(match);
        }

        public bool RemoveMatchFromTournament(long tournamentId, Match match)
        {
            return RemoveMatchFromTournament(FindTournament(tournamentId), match);
        }
    }
}
