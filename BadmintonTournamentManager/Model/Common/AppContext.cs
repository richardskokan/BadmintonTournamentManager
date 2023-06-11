using BadmintonTournamentManager.Controller.Common;
using BadmintonTournamentManager.Controller.Filesystem;
using BadmintonTournamentManager.Controller.Managers;
using BadmintonTournamentManager.Model.Objects;

namespace BadmintonTournamentManager.Model.Common
{
    public class AppContext
    {
        public readonly DBContext DBContext;

        public readonly UserManager Users;

        public PlayerManager Players;
        public TournamentManager Tournaments;
        public MatchManager Matches;

        public readonly MatchTreeGenerator MatchTreeGenerator;

        public AppContext()
        {
            DBContext = new DBContext();

            Users = new UserManager(this);

            Players = new PlayerManager(new());
            Matches = new MatchManager(this, new());
            Tournaments = new TournamentManager(new());

            MatchTreeGenerator = new MatchTreeGenerator(this);

            LoadAllAppData();
        }
        
        public void SaveAllData()
        {
            SavePlayers();
            SaveMatches();
            SaveTournaments();
        }

        public void SavePlayers()
        {
            DBContext.SaveData(Players.Players);
        }

        public void SaveMatches()
        {
            DBContext.SaveData(Matches.Matches);
        }

        public void SaveTournaments()
        {
            DBContext.SaveData(Tournaments.Tournaments);
        }

        private async void LoadAllAppData()
        {
            Players.UpdatePlayerSet(await DBContext.LoadData<Player>(Paths.PlayerFile));
            Matches.UpdateMatchSet(await DBContext.LoadData<Match>(Paths.MatchFile));
            Tournaments.UpdateTournamentSet(await DBContext.LoadData<Tournament>(Paths.TournamentFile));
        }

        public async Task<Dictionary<string, byte[]>> LoadUserDataAsync()
        {
            return await DBContext.LoadUsers();
        }
    }
}
