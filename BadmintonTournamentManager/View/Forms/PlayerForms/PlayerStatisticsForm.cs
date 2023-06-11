using BadmintonTournamentManager.Model.Objects;
using System.Reflection;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class PlayerStatisticsForm : Form
    {
        public PlayerStatisticsForm(Statistics statistics)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            matchesPlayedLabel.Text = statistics.MatchesPlayed.ToString();
            matchesWonLabel.Text = statistics.MatchesWon.ToString();
            matchesLostLabel.Text = statistics.MatchesLost.ToString();

            gamesWonLabel.Text = statistics.GamesWon.ToString();
            gamesLostLabel.Text = statistics.GamesLost.ToString();

            firstMatchLabel.Text = statistics.GetFirstMatchDateString();
            lastMatchLabel.Text = statistics.GetLastMatchDateString();
        }
    }
}
