using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class PlayerDetailForm : Form
    {
        private readonly AppContext AppContext;

        private readonly Player _player;

        public PlayerDetailForm(AppContext appContext, Player player)
        {
            InitializeComponent();

            _player = player;

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;

            if (!AppContext.Users.IsAdmin)
            {
                editButton.Visible = false;
                editButton.Enabled = false;

                idLabel.Visible = false;
                idTextLabel.Visible = false;
            }

            UpdateData();

            idLabel.Text = player.Id.ToString();
        }

        private void UpdateData()
        {
            surnameLabel.Text = _player.LastName;
            firstnameLabel.Text = _player.FirstName;

            birthdayLabel.Text = _player.GetDateOfBirthString();
            nationalityLabel.Text = _player.Nationality;

            informationLabel.Text = _player.Information;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            new PlayerStatisticsForm(_player.Statistics).Show(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new PlayerEditForm(AppContext, _player).ShowDialog(this);
            UpdateData();

            AppContext.SavePlayers();
        }
    }
}
