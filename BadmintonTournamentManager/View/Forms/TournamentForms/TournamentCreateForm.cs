using BadmintonTournamentManager.Model.Exceptions;
using System.Reflection;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms.TournamentForms
{
    public partial class TournamentCreateForm : Form
    {
        private readonly AppContext AppContext;

        private DateTime? _startDate;
        private DateTime? _endDate;

        public TournamentCreateForm(AppContext appContext)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;
        }

        private bool CreateTournament()
        {
            var name = tournamentNameTextBox.Text;
            var venue = venueNameTextBox.Text;

            var dateStart = DateTime.Parse(dateStartLabel.Text);
            var dateEnd = DateTime.Parse(dateEndLabel.Text);

            try
            {
                AppContext.Tournaments.CreateTournament(name, venue, dateStart, dateEnd);
            }
            catch (AppInvalidDataException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CreateTournament())
                Close();
        }

        private void SetStartDateButton_Click(object sender, EventArgs e)
        {
            _startDate = OpenDatePicker(dateStartLabel, _startDate, _endDate);
        }

        private void SetEndDateButton_Click(object sender, EventArgs e)
        {
            _endDate = OpenDatePicker(dateEndLabel, _startDate, _endDate);
        }

        private DateTime? OpenDatePicker(Label dateLabel, DateTime? start, DateTime? end)
        {
            var datePicker = new DatePickerForm(startDate: start, endDate: end);
            if (!string.IsNullOrEmpty(dateLabel.Text))
                datePicker.SetSelectedDate(DateTime.Parse(dateLabel.Text));

            datePicker.FormClosed += new FormClosedEventHandler(
                (sender, e) =>
                {
                    if (datePicker.PickedDate != null)
                        dateLabel.Text = datePicker.PickedDate.ToString();
                });

            datePicker.ShowDialog(this);
            return datePicker.PickedDate;
        }
    }
}
