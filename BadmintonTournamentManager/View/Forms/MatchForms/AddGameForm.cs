using BadmintonTournamentManager.Model.Exceptions;
using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms.MatchForms
{
    public partial class AddGameForm : Form
    {
        private readonly Match _match;

        public AddGameForm(AppContext appContext, Match match)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            _match = match;

            var player1 = appContext.Players.FindPlayer(match.Player1Id);
            var player2 = appContext.Players.FindPlayer(match.Player2Id);

            player1NameLabel.Text = player1 != null ? player1.GetFullName() : "Player 1";
            player2NameLabel.Text = player2 != null ? player2.GetFullName() : "Player 2";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _match.AddGame((int)player1ScoreNumeric.Value, (int)player2ScoreNumeric.Value);
                Close();
            }
            catch (AppInvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
