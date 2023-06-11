using BadmintonTournamentManager.Model.Helpers;
using BadmintonTournamentManager.Model.Objects;

namespace BadmintonTournamentManager.Controller.Managers
{
    public class PlayerManager
    {
        public HashSet<Player> Players { get; private set; }

        public PlayerManager(HashSet<Player> data)
        {
            Players = data;
        }

        public void UpdatePlayerSet(IEnumerable<Player> data)
        {
            foreach (var player in data)
                Players.Add(player);
        }

        private long GetNewId()
        {
            return Players.Count == 0 ? 1 : Players.Max(x => x.Id) + 1;
        }

        public Player FindPlayer(long playerId)
        {
            var player = Players.FirstOrDefault(p => p.Id == playerId);
            ValueCheckHelper.CheckObjectExists(player, "player");

            return player!;
        }

        public Player CreatePlayer(string firstName, string lastName, DateTime dateOfBirth, string? nationality, string? information)
        {
            var player = new Player(GetNewId());

            ValueCheckHelper.CheckString(firstName, "player's first name");
            player.FirstName = firstName;

            ValueCheckHelper.CheckString(lastName, "player's last name");
            player.LastName = lastName;

            ValueCheckHelper.CheckDateInRange(dateOfBirth, new DateTime(1900, 1, 1), DateTime.Today);
            player.DateOfBirth = dateOfBirth;

            if (nationality != null)
                player.Nationality = nationality;
            if (information != null)
                player.Information = information;

            Players.Add(player);
            return player;
        }

        public bool ManagePlayer(Player player, string? firstName, string? lastName, DateTime? dateOfBirth, string? nationality, string? information)
        {
            if (firstName != null)
            {
                ValueCheckHelper.CheckString(firstName, "player's first name");
                player.FirstName = firstName;
            }

            if (lastName != null)
            {
                ValueCheckHelper.CheckString(lastName, "player's last name");
                player.LastName = lastName;
            }

            if (dateOfBirth != null)
            {
                ValueCheckHelper.CheckDateInRange((DateTime)dateOfBirth, new DateTime(1900, 1, 1), DateTime.Today);
                player.DateOfBirth = (DateTime)dateOfBirth;
            }

            if (nationality != null)
                player.Nationality = nationality;

            if (information != null)
                player.Information = information;

            return true;
        }

        public bool ManagePlayer(long playerId, string? firstName, string? lastName, DateTime? dateOfBirth, string? nationality, string? information)
        {
            return ManagePlayer(FindPlayer(playerId), firstName, lastName, dateOfBirth, nationality, information);
        }

        public bool UpdatePlayerStatistics(Player player, Match match)
        {
            return player.Statistics.AddMatch(player, match);
        }

        public bool UpdatePlayerStatistics(long playerId, Match match)
        {
            return UpdatePlayerStatistics(FindPlayer(playerId), match);
        }

        public bool DeletePlayer(Player player)
        {
            return Players.Remove(player);
        }

        public bool DeletePlayer(long playerId)
        {
            return DeletePlayer(FindPlayer(playerId));
        }
    }
}
