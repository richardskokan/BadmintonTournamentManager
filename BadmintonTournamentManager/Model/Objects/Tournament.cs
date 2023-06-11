using BadmintonTournamentManager.Model.Common;
using System.Collections.ObjectModel;

namespace BadmintonTournamentManager.Model.Objects
{
    public class Tournament : ISaveable
    {
        public long Id { get; set; }

        public string Name { get; set; } = "";
        public string Venue { get; set; } = "";
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public HashSet<long> PlayerIds { get; set; } = new();
        public HashSet<long> MatchIds { get; set;  } = new();

        public Tournament() { }

        public Tournament(long id)
        {
            Id = id;
        }

        public string GetMatchTree()
        {
            return "Fuck off";
        }

        public string GetDateStartString()
        {
            return $"{DateStart:d\\. M\\. yyyy}";
        }

        public string GetDateEndString()
        {
            return $"{DateEnd:d\\. M\\. yyyy}";
        }

        public bool AddPlayer(Player player)
        {
            return PlayerIds.Add(player.Id);
        }

        public bool AddMatch(Match match)
        {
            return MatchIds.Add(match.Id);
        }
            
        public bool RemovePlayer(Player player)
        {
            return PlayerIds.Remove(player.Id);
        }

        public bool RemoveMatch(Match match)
        {
            return MatchIds.Remove(match.Id);
        }

        public ReadOnlyCollection<long> GetPlayerIds()
        {
            return new ReadOnlyCollection<long>(PlayerIds.ToList());
        }

        public ReadOnlyCollection<long> GetMatchIds()
        {
            return new ReadOnlyCollection<long>(MatchIds.ToList());
        }
    }
}
