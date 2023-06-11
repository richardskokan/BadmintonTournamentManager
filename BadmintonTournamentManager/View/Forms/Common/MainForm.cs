using BadmintonTournamentManager.Model.Objects;
using BadmintonTournamentManager.View.Forms.TournamentForms;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppContext AppContext;

        private bool _displayTournaments = true;

        public MainForm(AppContext appContext)
        {
            AppContext = appContext;

            Application.Run(new LoginForm(AppContext));

            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            usernameLabel.Text = AppContext.Users.loggedUser != "" ? AppContext.Users.loggedUser : "Guest";

            if (!AppContext.Users.IsAdmin)
            {
                addEntityButton.Enabled = false;
                addEntityButton.Visible = false;
            }

            SwitchListViewToTournaments();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            AppContext.Users.Logout();

            Application.Restart();
            Close();
        }

        private void SwitchListButton_Click(object sender, EventArgs e)
        {
            _displayTournaments = !_displayTournaments;

            if (_displayTournaments)
                SwitchListViewToTournaments();
            else
                SwitchListViewToPlayers();
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            if (_displayTournaments)
            {
                new TournamentCreateForm(AppContext).ShowDialog(this);
                SwitchListViewToTournaments();

                AppContext.SaveTournaments();
            }
            else
            {
                new PlayerEditForm(AppContext).ShowDialog(this);
                SwitchListViewToPlayers();

                AppContext.SavePlayers();
            }
        }

        private void SwitchListViewToTournaments()
        {
            switchListButton.Text = "Switch view to Players";
            addEntityButton.Text = "Add Tournament";

            entityListView.Clear();

            entityListView.Columns.Add("Tournament name");
            entityListView.Columns.Add("Starting on:");
            entityListView.Columns.Add("Ending on:");

            entityListView.View = System.Windows.Forms.View.Details;

            foreach (var tournament in AppContext.Tournaments.Tournaments)
            {
                var newItem = new ListViewItem();
                newItem.Tag = tournament;

                newItem.Text = tournament.Name;
                newItem.SubItems.Add(tournament.GetDateStartString());
                newItem.SubItems.Add(tournament.GetDateEndString());

                entityListView.Items.Add(newItem);
            }

            entityListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            entityListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            entityListView.Update();
        }

        private void SwitchListViewToPlayers()
        {
            switchListButton.Text = "Switch view to Tournaments";
            addEntityButton.Text = "Add Player";

            entityListView.Clear();

            entityListView.Columns.Add("Surname");
            entityListView.Columns.Add("Name");
            entityListView.Columns.Add("Nationality");

            entityListView.View = System.Windows.Forms.View.Details;

            foreach (var player in AppContext.Players.Players)
            {
                var newItem = new ListViewItem();
                newItem.Tag = player;

                newItem.Text = player.LastName;
                newItem.SubItems.Add(player.FirstName);
                newItem.SubItems.Add(player.Nationality);

                entityListView.Items.Add(newItem);
            }

            entityListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            entityListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            entityListView.Update();
        }

        private void ObjectListView_ItemActivate(object sender, EventArgs e)
        {
            var item = entityListView.SelectedItems[0].Tag;

            if (_displayTournaments)
                new TournamentDetailForm(AppContext, (Tournament)item).Show(this);
            else
                new PlayerDetailForm(AppContext, (Player)item).Show(this);
        }
    }
}
