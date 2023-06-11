using BadmintonTournamentManager.Model.Exceptions;
using BadmintonTournamentManager.Model.Objects;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class PlayerEditForm : Form
    {
        private readonly AppContext AppContext;

        private readonly Player? _player;

        public PlayerEditForm(AppContext appContext, Player player)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;
            _player = player;

            lastNameTextBox.Text = player.LastName;
            firstNameTextBox.Text = player.FirstName;

            birthDateLabel.Text = player.GetDateOfBirthString();
            nationalityTextBox.Text = player.Nationality;

            informationTextBox.Text = player.Information;
        }

        public PlayerEditForm(AppContext appContext)
        {
            InitializeComponent();

            AppContext = appContext;
        }

        private bool UpdatePlayer()
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;

            var birthDay = DateTime.Parse(birthDateLabel.Text);

            var nationality = nationalityTextBox.Text;

            var information = informationTextBox.Text;

            try
            {
                AppContext.Players.ManagePlayer(_player!, firstName, lastName, birthDay, nationality, information);
            }
            catch (AppInvalidDataException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CreatePlayer()
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;

            var birthDay = DateTime.Parse(birthDateLabel.Text);
            var nationality = nationalityTextBox.Text;

            var information = informationTextBox.Text;

            try
            {
                AppContext.Players.CreatePlayer(firstName, lastName, birthDay, nationality, information);
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
            if (_player != null && UpdatePlayer())
                Close();
            else if (CreatePlayer())
                Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenDatePickerButton_Click(object sender, EventArgs e)
        {
            var datePicker = new DatePickerForm(endDate: DateTime.Today);

            if (!string.IsNullOrEmpty(birthDateLabel.Text))
                datePicker.SetSelectedDate(DateTime.Parse(birthDateLabel.Text));

            datePicker.FormClosed += new FormClosedEventHandler(
                (sender, e) =>
                {
                    if (datePicker.PickedDate != null)
                        birthDateLabel.Text = datePicker.PickedDate.ToString();
                });

            datePicker.ShowDialog(this);
        }
    }
}
