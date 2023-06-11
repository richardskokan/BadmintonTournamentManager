namespace BadmintonTournamentManager.Controller.Filesystem
{
    public static class Paths
    {
        private static string ExecutionPath = AppDomain.CurrentDomain.BaseDirectory;

        public static string DataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
            AppDomain.CurrentDomain.FriendlyName,
            "data");

        public static string UserFile = Path.Combine(ExecutionPath, "users.json");

        public static string PlayerFile = Path.Combine(DataDirectory, "players.json");
        public static string TournamentFile = Path.Combine(DataDirectory, "tournaments.json");
        public static string MatchFile = Path.Combine(DataDirectory, "matches.json");

        public static string MatchTreeFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }
}
