using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class MatchDetailForm : Form
    {
        private readonly AppContext AppContext;

        private readonly Match _match;

        private readonly Player? _player1;
        private readonly Player? _player2;

        public MatchDetailForm(AppContext appContext, Match match)
        {
            _match = match;

            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            if (!AppContext.Users.IsAdmin)
            {
                editButton.Visible = false;
                editButton.Enabled = false;

                idLabel.Visible = false;
                idTextLabel.Visible = false;
            }

            _player1 = SetPlayer(match.Player1Id, match.PreviousMatch1Id);
            _player2 = SetPlayer(match.Player2Id, match.PreviousMatch2Id);

            UpdateDataDisplay();
        }

        private Player? SetPlayer(long playerId, long prevMatchId)
        {
            if (playerId == -1 && prevMatchId != -1)
                playerId = AppContext.Matches.FindMatch(prevMatchId).GetWinner();
            if (playerId == -1)
                return null;

            return AppContext.Players.FindPlayer(playerId);
        }

        private void UpdateDataDisplay()
        {
            matchNameLabel.Text = _match.Name;

            if (_player1 != null)
                player1NameLabel.Text = _player1.GetFullName();
            if (_player2 != null)
                player2NameLabel.Text = _player2.GetFullName();

            dateTimeLabel.Text = _match.GetStartTimeString();
            courtLabel.Text = _match.VenueCourt;

            (int player1Score, int player2Score) = _match!.GetPlayerScores();

            player1ScoreLabel.Text = player1Score.ToString();
            player2ScoreLabel.Text = player2Score.ToString();

            gameListLabel.Text = "(" + _match.GetGameListScores() + ")";

            idLabel.Text = _match.Id.ToString();
        }

        private void Player1NameLabel_Click(object sender, EventArgs e)
        {
            if (_player1 == null)
                return;

            new PlayerDetailForm(AppContext, _player1).Show(this);
        }

        private void Player2NameLabel_Click(object sender, EventArgs e)
        {
            if (_player2 == null)
                return;

            new PlayerDetailForm(AppContext, _player2).Show(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new MatchEditForm(AppContext, _match).ShowDialog(this);

            UpdateDataDisplay();

            AppContext.SaveMatches();
            AppContext.SavePlayers();
        }
    }
}
