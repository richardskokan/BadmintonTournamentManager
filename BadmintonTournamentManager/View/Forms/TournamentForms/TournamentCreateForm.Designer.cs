namespace BadmintonTournamentManager.View.Forms.TournamentForms
{
    partial class TournamentCreateForm
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
            cancelButton = new Button();
            setEndDateButton = new Button();
            setStartDateButton = new Button();
            dateEndLabel = new Label();
            dateStartLabel = new Label();
            venueNameTextBox = new TextBox();
            tournamentNameTextBox = new TextBox();
            saveButton = new Button();
            label4 = new Label();
            label3 = new Label();
            venueLabel = new Label();
            tournamentNameLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(12, 197);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 23);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // setEndDateButton
            // 
            setEndDateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setEndDateButton.Location = new Point(192, 142);
            setEndDateButton.Name = "setEndDateButton";
            setEndDateButton.Size = new Size(35, 23);
            setEndDateButton.TabIndex = 36;
            setEndDateButton.Text = "Set";
            setEndDateButton.UseVisualStyleBackColor = true;
            setEndDateButton.Click += SetEndDateButton_Click;
            // 
            // setStartDateButton
            // 
            setStartDateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setStartDateButton.Location = new Point(192, 118);
            setStartDateButton.Name = "setStartDateButton";
            setStartDateButton.Size = new Size(35, 23);
            setStartDateButton.TabIndex = 35;
            setStartDateButton.Text = "Set";
            setStartDateButton.UseVisualStyleBackColor = true;
            setStartDateButton.Click += SetStartDateButton_Click;
            // 
            // dateEndLabel
            // 
            dateEndLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateEndLabel.Location = new Point(78, 146);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new Size(108, 15);
            dateEndLabel.TabIndex = 34;
            // 
            // dateStartLabel
            // 
            dateStartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateStartLabel.Location = new Point(78, 122);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new Size(108, 15);
            dateStartLabel.TabIndex = 33;
            // 
            // venueNameTextBox
            // 
            venueNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            venueNameTextBox.Location = new Point(12, 73);
            venueNameTextBox.Name = "venueNameTextBox";
            venueNameTextBox.Size = new Size(218, 23);
            venueNameTextBox.TabIndex = 32;
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tournamentNameTextBox.Location = new Point(12, 28);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(218, 23);
            tournamentNameTextBox.TabIndex = 31;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(128, 197);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 23);
            saveButton.TabIndex = 30;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 29;
            label4.Text = "Date end:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 28;
            label3.Text = "Date start:";
            // 
            // venueLabel
            // 
            venueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            venueLabel.AutoSize = true;
            venueLabel.Location = new Point(12, 55);
            venueLabel.Name = "venueLabel";
            venueLabel.Size = new Size(75, 15);
            venueLabel.TabIndex = 27;
            venueLabel.Text = "Venue name:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(12, 9);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(107, 15);
            tournamentNameLabel.TabIndex = 26;
            tournamentNameLabel.Text = "Tournament name:";
            // 
            // TournamentCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 231);
            Controls.Add(cancelButton);
            Controls.Add(setEndDateButton);
            Controls.Add(setStartDateButton);
            Controls.Add(dateEndLabel);
            Controls.Add(dateStartLabel);
            Controls.Add(venueNameTextBox);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(venueLabel);
            Controls.Add(tournamentNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TournamentCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button setEndDateButton;
        private Button setStartDateButton;
        private Label dateEndLabel;
        private Label dateStartLabel;
        private TextBox venueNameTextBox;
        private TextBox tournamentNameTextBox;
        private Button saveButton;
        private Label label4;
        private Label label3;
        private Label venueLabel;
        private Label tournamentNameLabel;
    }
}