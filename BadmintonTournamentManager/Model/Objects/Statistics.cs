namespace BadmintonTournamentManager.Model.Objects
{
    public class Statistics
    {
        public int MatchesPlayed { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesLost { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public DateTime? FirstMatch { get; set; }
        public DateTime? LastMatch { get; set; }

        public Statistics() { }

        public bool AddMatch(Player player, Match match)
        {
            if (match.Status != Helpers.MatchStatusEnum.ENDED)
                return false;

            MatchesPlayed++;

            if (match.GetWinner() == player.Id)
            {
                MatchesWon++;
            }
            else
            {
                MatchesLost++;
            }

            (int gamesWon, int gamesLost) = match.GetGamesStats(player);
            
            GamesWon += gamesWon;
            GamesLost += gamesLost;

            if (FirstMatch == null || FirstMatch > match.StartTime)
            {
                FirstMatch = match.StartTime;
            }
            if (LastMatch == null || LastMatch < match.StartTime)
            {
                LastMatch = match.StartTime;
            }

            return true;
        }

        public string GetFirstMatchDateString()
        {
            return $"{FirstMatch:d\\. M\\. yyyy H:m}";
        }

        public string GetLastMatchDateString()
        {
            return $"{LastMatch:d\\. M\\. yyyy H:m}";
        }
    }
}
