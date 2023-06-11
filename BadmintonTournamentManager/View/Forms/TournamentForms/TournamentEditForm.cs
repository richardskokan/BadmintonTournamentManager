using BadmintonTournamentManager.Model.Exceptions;
using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;
using Match = BadmintonTournamentManager.Model.Objects.Match;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class TournamentEditForm : Form
    {
        private readonly AppContext AppContext;

        private readonly Tournament _tournament;

        public TournamentEditForm(AppContext appContext, Tournament tournament)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            _tournament = tournament;

            tournamentNameTextBox.Text = tournament.Name;
            venueNameTextBox.Text = tournament.Venue;

            dateStartLabel.Text = tournament.GetDateStartString();
            dateEndLabel.Text = tournament.GetDateEndString();

            idLabel.Text = tournament.Id.ToString();

            matchListView.Columns.Add("Name");
            matchListView.Columns.Add("Date");
            matchListView.Columns.Add(" ");
            matchListView.Columns.Add("vs.");
            matchListView.Columns.Add(" ");

            matchListView.View = System.Windows.Forms.View.Details;

            UpdateMatchList();
        }

        private void UpdateMatchList()
        {
            if (_tournament == null)
            {
                return;
            }

            matchListView.Items.Clear();

            var matches = AppContext.Matches.FindAllMatchesWithId(_tournament.GetMatchIds());
            foreach (var match in matches)
            {
                var newItem = new ListViewItem();
                newItem.Tag = match;

                newItem.Text = match.Name;

                newItem.SubItems.Add(match.GetStartTimeString());

                AddPlayerOrMatch(match.Player1Id, match.PreviousMatch1Id, newItem);

                newItem.SubItems.Add("");

                AddPlayerOrMatch(match.Player2Id, match.PreviousMatch2Id, newItem);

                matchListView.Items.Add(newItem);
            }

            matchListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            matchListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            matchListView.Update();

            void AddPlayerOrMatch(long playerId, long prevMatchId, ListViewItem newItem)
            {
                if (playerId != -1)
                {
                    var player = AppContext.Players.FindPlayer(playerId);
                    newItem.SubItems.Add(player != null ? player.GetFullName() : "N/A");
                }
                else if (prevMatchId != -1)
                {
                    var prevMatch = AppContext.Matches.FindMatch(prevMatchId);
                    if (prevMatch == null)
                    {
                        newItem.SubItems.Add("N/A");
                        return;
                    }

                    var winnerId = prevMatch.GetWinner();
                    newItem.SubItems.Add(winnerId == -1 ? $"{prevMatch.Name} winner" : AppContext.Players.FindPlayer(winnerId).GetFullName());
                }
                else
                {
                    newItem.SubItems.Add(" ");
                }
            }
        }

        private void UpdateMatchListEvent(object sender, FormClosedEventArgs e)
        {
            UpdateMatchList();
        }

        private void MatchListView_ItemActivate(object sender, EventArgs e)
        {
            var matchDetail = new MatchDetailForm(AppContext, (Match)matchListView.SelectedItems[0].Tag);
            matchDetail.FormClosed += new FormClosedEventHandler(UpdateMatchListEvent!);
            matchDetail.Show(this);
        }

        private bool UpdateTournament()
        {
            var name = tournamentNameTextBox.Text;
            var venue = venueNameTextBox.Text;

            var dateStart = DateTime.Parse(dateStartLabel.Text);
            var dateEnd = DateTime.Parse(dateEndLabel.Text);

            try
            {
                AppContext.Tournaments.ManageTournament(_tournament, name, venue, dateStart, dateEnd);
            }
            catch (AppInvalidDataException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateTournament();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddMatchButton_Click(object sender, EventArgs e)
        {
            new MatchEditForm(AppContext, _tournament).ShowDialog();
            UpdateMatchList();
        }

        private void DeleteMatchButton_Click(object sender, EventArgs e)
        {
            if (matchListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No match was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var match = (Match) matchListView.SelectedItems[0].Tag;
            AppContext.Matches.DeleteMatch(AppContext, match);
            UpdateMatchList();
        }

        private void SetStartDateButton_Click(object sender, EventArgs e)
        {
            OpenDatePicker(dateStartLabel, startDate: null, endDate: _tournament.DateEnd);
        }

        private void SetEndDateButton_Click(object sender, EventArgs e)
        {
            OpenDatePicker(dateEndLabel, startDate: _tournament.DateStart, endDate: null);
        }

        private void OpenDatePicker(Label dateLabel, DateTime? startDate, DateTime? endDate)
        {
            var datePicker = new DatePickerForm(startDate: startDate, endDate: endDate);

            if (!string.IsNullOrEmpty(dateLabel.Text))
                datePicker.SetSelectedDate(DateTime.Parse(dateLabel.Text));

            datePicker.FormClosed += new FormClosedEventHandler(
                (sender, e) =>
                {
                    if (datePicker.PickedDate != null)
                        dateLabel.Text = $"{datePicker.PickedDate:d\\. M\\. yyyy}";
                });

            datePicker.ShowDialog(this);
        }
    }
}
