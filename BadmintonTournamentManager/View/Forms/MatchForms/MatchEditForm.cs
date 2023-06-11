using BadmintonTournamentManager.Model.Exceptions;
using BadmintonTournamentManager.Model.Objects;
using BadmintonTournamentManager.View.Forms.MatchForms;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class MatchEditForm : Form
    {
        private readonly AppContext AppContext;

        private Match? _match;
        private readonly Tournament _tournament;

        private Player? _player1;
        private Player? _player2;

        private Match? _previousMatch1;
        private Match? _previousMatch2;

        public MatchEditForm(AppContext appContext, Tournament tournament)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            _tournament = tournament;

            addGameButton.Enabled = false;
            addGameButton.Visible = false;
        }

        public MatchEditForm(AppContext appContext, Match match)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            _match = match;
            _tournament = AppContext.Tournaments.FindTournament(match.TournamentId);

            _player1 = appContext.Players.FindPlayer(match.Player1Id);
            _player2 = appContext.Players.FindPlayer(match.Player2Id);

            matchNameTextBox.Text = match.Name;

            UpdatePlayerDisplay();
            UpdateScoreDisplay();

            dateTimeLabel.Text = match.GetStartTimeString();
            courtTextBox.Text = match.VenueCourt;

            idLabel.Text = match.Id.ToString();

        }

        private void UpdatePlayerDisplay()
        {
            if (_player1 != null)
            {
                player1NameLabel.Text = _player1.GetFullName();
            }
            else if (_previousMatch1 != null)
            {
                var winnerId = _previousMatch1.GetWinner();
                
                Player? winner;
                if (winnerId == -1)
                    winner = null;
                else
                    winner = AppContext.Players.FindPlayer(winnerId);

                player1NameLabel.Text = winner == null ? $"{_previousMatch1.Name} winner" : winner.GetFullName();
            }

            if (_player2 != null)
            {
                player2NameLabel.Text = _player2.GetFullName();
            }
            else if (_previousMatch2 != null)
            {
                var winnerId = _previousMatch2.GetWinner();

                Player? winner;
                if (winnerId == -1)
                    winner = null;
                else
                    winner = AppContext.Players.FindPlayer(winnerId);

                player2NameLabel.Text = winner == null ? $"{_previousMatch2.Name} winner" : winner.GetFullName();
            }
        }

        private void UpdateScoreDisplay()
        {
            (int player1Score, int player2Score) = _match!.GetPlayerScores();

            player1ScoreLabel.Text = player1Score.ToString();
            player2ScoreLabel.Text = player2Score.ToString();
        }

        private bool UpdateMatch()
        {
            if (_match == null)
                return false;

            var name = matchNameTextBox.Text;
            var court = courtTextBox.Text;
            var startTime = DateTime.Parse(dateTimeLabel.Text);

            try
            {
                AppContext.Matches.ManageMatch(_match, name, court, startTime);
            }
            catch (AppInvalidDataException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_player1 != null)
                if (!AppContext.Matches.AddPlayer1ToMatch(_match, _player1))
                    return false;

            if (_player2 != null)
                if (!AppContext.Matches.AddPlayer2ToMatch(_match, _player2))
                    return false;

            if (_previousMatch1 != null)
                if (!AppContext.Matches.AddPreviousMatch1ToMatch(_match, _previousMatch1))
                    return false;

            if (_previousMatch2 != null)
                if (!AppContext.Matches.AddPreviousMatch2ToMatch(_match, _previousMatch2))
                    return false;

            return true;
        }

        private bool CreateMatch()
        {
            if (_tournament == null)
                return false;

            var name = matchNameTextBox.Text;
            var court = courtTextBox.Text;
            var startTime = DateTime.Parse(dateTimeLabel.Text);

            try
            {
                _match = AppContext.Matches.CreateMatch(_tournament, name, court, startTime);
            }
            catch (AppInvalidDataException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_player1 != null)
                if (!AppContext.Matches.AddPlayer1ToMatch(_match, _player1))
                    return false;

            if (_player2 != null)
                if (!AppContext.Matches.AddPlayer2ToMatch(_match, _player2))
                    return false;

            if (_previousMatch1 != null)
                if (!AppContext.Matches.AddPreviousMatch1ToMatch(_match, _previousMatch1))
                    return false;

            if (_previousMatch2 != null)
                if (!AppContext.Matches.AddPreviousMatch2ToMatch(_match, _previousMatch2))
                    return false;

            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_match != null && UpdateMatch())
                Close();
            else if (_match == null && CreateMatch())
                Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            new AddGameForm(AppContext, _match!).ShowDialog(this);
            UpdateScoreDisplay();
        }

        private void SelectPlayer1Button_Click(object sender, EventArgs e)
        {
            var selection = new EntitySelectionForm(AppContext, _tournament, _match);
            selection.ShowDialog(this);

            if (selection.SelectedPlayer != null)
            { 
                _player1 = selection.SelectedPlayer;
                _previousMatch1 = null;
            }
            if (selection.SelectedMatch != null)
            {
                _previousMatch1 = selection.SelectedMatch;
                _player1 = null;
            }

            UpdatePlayerDisplay();
        }

        private void SelectPlayer2Button_Click(object sender, EventArgs e)
        {
            var selection = new EntitySelectionForm(AppContext, _tournament, _match);
            selection.ShowDialog(this);

            if (selection.SelectedPlayer != null)
            {
                _player2 = selection.SelectedPlayer;
                _previousMatch2 = null;
            }
            if (selection.SelectedMatch != null)
            {
                _previousMatch2 = selection.SelectedMatch;
                _player2 = null;
            }

            UpdatePlayerDisplay();
        }

        private void SetDateTimeButton_Click(object sender, EventArgs e)
        {
            var datePicker = new DatePickerForm(pickTime: true, startDate: _tournament.DateStart, endDate: _tournament.DateEnd);

            if (!string.IsNullOrEmpty(dateTimeLabel.Text))
                datePicker.SetSelectedDate(DateTime.Parse(dateTimeLabel.Text));

            datePicker.FormClosed += new FormClosedEventHandler(
                (sender, e) =>
                {
                    if (datePicker.PickedDate != null)
                        dateTimeLabel.Text = $"{datePicker.PickedDate:d\\. M\\. yyyy HH:mm}";
                });

            datePicker.ShowDialog(this);
        }
    }
}
