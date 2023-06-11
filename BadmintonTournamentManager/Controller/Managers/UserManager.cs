using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.Controller.Managers
{
    public class UserManager
    {
        private readonly AppContext AppContext;

        public Dictionary<string, byte[]> Users = new();

        public UserManager(AppContext appContext)
        {
            AppContext = appContext;

            LoadData();
        }

        private async void LoadData()
        {
            Users = await AppContext.LoadUserDataAsync();
        }

        public bool IsAdmin { get; private set; }
        public string loggedUser { get; private set; } = "";

        public bool Login(string username, byte[] passwordHash)
        {
            if (passwordHash.SequenceEqual(Users.GetValueOrDefault(username, new byte[0])))
            {
                IsAdmin = true;
                loggedUser = username;

                return true;
            }

            return false;
        }

        public bool Logout()
        {
            IsAdmin = false;
            loggedUser = "";

            return true;
        }
    }
}
