using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class TournamentDetailForm : Form
    {
        private readonly AppContext AppContext;

        private readonly Tournament _tournament;

        public TournamentDetailForm(AppContext appContext, Tournament tournament)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            _tournament = tournament;

            if (!AppContext.Users.IsAdmin)
            {
                editButton.Visible = false;
                editButton.Enabled = false;

                idLabel.Visible = false;
                idTextLabel.Visible = false;
            }

            UpdateData();
            idLabel.Text = tournament.Id.ToString();

            matchListView.Columns.Add("Name");
            matchListView.Columns.Add("Date");
            matchListView.Columns.Add(" ");
            matchListView.Columns.Add("vs.");
            matchListView.Columns.Add(" ");

            matchListView.View = System.Windows.Forms.View.Details;

            UpdateMatchList();
        }

        private void UpdateData()
        {
            tournamentNameLabel.Text = _tournament.Name;
            venueLabel.Text = _tournament.Venue;

            dateStartLabel.Text = _tournament.GetDateStartString();
            dateEndLabel.Text = _tournament.GetDateEndString();
        }

        private void UpdateMatchList()
        {
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            new TournamentEditForm(AppContext, _tournament).ShowDialog(this);
            UpdateData();
            UpdateMatchList();

            AppContext.SaveAllData();
        }

        private void generateTreeButton_Click(object sender, EventArgs e)
        {
            var selectionForm = new EntitySelectionForm(AppContext, _tournament, null, true);
            selectionForm.ShowDialog();

            if (selectionForm.SelectedMatch == null)
                return;

            AppContext.MatchTreeGenerator.GenerateMatchTree(selectionForm.SelectedMatch);
        }
    }
}
