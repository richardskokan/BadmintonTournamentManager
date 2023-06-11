namespace BadmintonTournamentManager.View.Forms
{
    partial class DatePickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar = new MonthCalendar();
            selectButton = new Button();
            colonLabel = new Label();
            minutesNumeric = new NumericUpDown();
            hoursNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)minutesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumeric).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(0, 0);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ScrollChange = 1;
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 0;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(0, 187);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(227, 23);
            selectButton.TabIndex = 1;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += SelectButton_Click;
            // 
            // colonLabel
            // 
            colonLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            colonLabel.Location = new Point(105, 164);
            colonLabel.Name = "colonLabel";
            colonLabel.Size = new Size(17, 23);
            colonLabel.TabIndex = 2;
            colonLabel.Text = ":";
            colonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minutesNumeric
            // 
            minutesNumeric.Location = new Point(128, 164);
            minutesNumeric.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minutesNumeric.Name = "minutesNumeric";
            minutesNumeric.Size = new Size(50, 23);
            minutesNumeric.TabIndex = 3;
            minutesNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // hoursNumeric
            // 
            hoursNumeric.Location = new Point(49, 164);
            hoursNumeric.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursNumeric.Name = "hoursNumeric";
            hoursNumeric.Size = new Size(50, 23);
            hoursNumeric.TabIndex = 4;
            hoursNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // DatePickerForm
            // 
            AcceptButton = selectButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 209);
            Controls.Add(hoursNumeric);
            Controls.Add(minutesNumeric);
            Controls.Add(colonLabel);
            Controls.Add(selectButton);
            Controls.Add(monthCalendar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DatePickerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pick a date";
            ((System.ComponentModel.ISupportInitialize)minutesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button selectButton;
        private Label colonLabel;
        private NumericUpDown minutesNumeric;
        private NumericUpDown hoursNumeric;
    }
}