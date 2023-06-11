using BadmintonTournamentManager.View.Forms;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager
{
    internal static class Program
    {
        private static AppContext Context = new AppContext();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run( new MainForm(Context) );
        }
    }
}