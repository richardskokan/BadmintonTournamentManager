namespace BadmintonTournamentManager.View.Forms
{
    // Implementation used is from https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.monthcalendar?view=windowsdesktop-7.0
    // and was modified to better suit the use-case of this app.
    public partial class DatePickerForm : Form
    {
        public DateTime? PickedDate { get; private set; } = null;
        private bool _pickTime;

        public DatePickerForm(bool pickTime = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            InitializeComponent();

            monthCalendar.MinDate = startDate != null ? (DateTime)startDate : new DateTime(1900, 1, 1);
            monthCalendar.MaxDate = endDate != null ? (DateTime)endDate : new DateTime(2050, 12, 31);

            _pickTime = pickTime;

            if (!_pickTime)
            {
                hoursNumeric.Enabled = false;
                hoursNumeric.Visible = false;

                minutesNumeric.Enabled = false;
                minutesNumeric.Visible = false;

                colonLabel.Visible = false;
            }
        }

        public void SetSelectedDate(DateTime selectedDate)
        {
            monthCalendar.SelectionStart = selectedDate;

            if (_pickTime)
            {
                hoursNumeric.Value = selectedDate.Hour;
                minutesNumeric.Value = selectedDate.Minute;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            PickedDate = monthCalendar.SelectionStart.Date;

            if (_pickTime)
            {
                PickedDate = new DateTime(
                    PickedDate.Value.Year,
                    PickedDate.Value.Month,
                    PickedDate.Value.Day,
                    (int)hoursNumeric.Value,
                    (int)minutesNumeric.Value,
                    0
                    );
            }

            Close();
        }
    }
}
