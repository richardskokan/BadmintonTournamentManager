using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class EntitySelectionForm : Form
    {
        private readonly AppContext AppContext;

        public Player? SelectedPlayer { get; private set; }
        public Match? SelectedMatch { get; private set; }
        public bool SelectFromMatch { get; private set; }

        private readonly Tournament _tournament;
        private readonly Match? _match;

        public EntitySelectionForm(AppContext appContext, Tournament tournament, Match? match, bool showMatchOnly = false)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            _tournament = tournament;
            _match = match;

            if (showMatchOnly)
            {
                changeSelectListButton.Enabled = false;
                changeSelectListButton.Visible = false;

                UpdateMatchList();
            }
            else
                UpdatePlayerList();
        }

        private void UpdatePlayerList()
        {
            SelectFromMatch = false;
            Text = "Select Player";
            changeSelectListButton.Text = "Select from Players";

            entitiesListView.Clear();

            entitiesListView.Columns.Add("Surname");
            entitiesListView.Columns.Add("Name");
            entitiesListView.Columns.Add("Nationality");

            entitiesListView.View = System.Windows.Forms.View.Details;

            foreach (var player in AppContext.Players.Players)
            {
                var newItem = new ListViewItem();
                newItem.Tag = player;

                newItem.Text = player.LastName;
                newItem.SubItems.Add(player.FirstName);
                newItem.SubItems.Add(player.Nationality);

                entitiesListView.Items.Add(newItem);
            }

            entitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            entitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            entitiesListView.Update();
        }

        private void UpdateMatchList()
        {
            SelectFromMatch = true;
            Text = "Select Match";
            changeSelectListButton.Text = "Select from Matches";

            entitiesListView.Clear();

            entitiesListView.Columns.Add("Name");
            entitiesListView.Columns.Add("Time");

            entitiesListView.View = System.Windows.Forms.View.Details;

            var matches = AppContext.Matches.FindAllMatchesWithId(_tournament.GetMatchIds());
            foreach (var match in matches)
            {
                if (match == _match)
                    continue;

                var newItem = new ListViewItem();
                newItem.Tag = match;

                newItem.Text = match.Name;
                newItem.SubItems.Add(match.GetStartTimeString());

                entitiesListView.Items.Add(newItem);
            }

            entitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            entitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            entitiesListView.Update();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (entitiesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No value selected.", "Error");
                return;
            }

            if (SelectFromMatch)
                SelectedMatch = (Match)entitiesListView.SelectedItems[0].Tag;
            else
                SelectedPlayer = (Player)entitiesListView.SelectedItems[0].Tag;

            Close();
        }

        private void EntitiesListView_ItemActivate(object sender, EventArgs e)
        {
            if (SelectFromMatch)
            {
                var match = entitiesListView.SelectedItems[0].Tag;
                new MatchDetailForm(AppContext, (Match)match).ShowDialog(this);
            }
            else
            {
                var player = entitiesListView.SelectedItems[0].Tag;
                new PlayerDetailForm(AppContext, (Player)player).ShowDialog(this);
            }

            entitiesListView.Update();
        }

        private void ChangeSelectListButton_Click(object sender, EventArgs e)
        {
            if (SelectFromMatch)
                UpdatePlayerList();
            else
                UpdateMatchList();
        }
    }
}
