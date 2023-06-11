using BadmintonTournamentManager.Model.Common;

namespace BadmintonTournamentManager.Model.Objects
{
    public class Player : ISaveable
    {
        public long Id { get; set; }

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; } = "";
        public string Information { get; set; } = "";
        public Statistics Statistics { get; set; } = new Statistics();

        public Player() { }

        public Player(long id)
        {
            Id = id;
        }

        public string GetDateOfBirthString()
        {
            return $"{DateOfBirth:d\\. M\\. yyyy}";
        }

        public string GetFullName()
        {
            return LastName + " " + FirstName;
        }
    }
}
