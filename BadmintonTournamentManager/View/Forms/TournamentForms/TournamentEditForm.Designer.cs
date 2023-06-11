namespace BadmintonTournamentManager.View.Forms
{
    partial class TournamentEditForm
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
            idLabel = new Label();
            idTextLabel = new Label();
            saveButton = new Button();
            label4 = new Label();
            label3 = new Label();
            venueLabel = new Label();
            tournamentNameLabel = new Label();
            matchListView = new ListView();
            tournamentNameTextBox = new TextBox();
            venueNameTextBox = new TextBox();
            dateStartLabel = new Label();
            dateEndLabel = new Label();
            setStartDateButton = new Button();
            setEndDateButton = new Button();
            cancelButton = new Button();
            deleteMatchButton = new Button();
            addMatchButton = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(405, 301);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 17;
            idLabel.Text = "      ";
            // 
            // idTextLabel
            // 
            idTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(378, 301);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 16;
            idTextLabel.Text = "ID:";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(478, 326);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 23);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(378, 130);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Date end:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(378, 106);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 13;
            label3.Text = "Date start:";
            // 
            // venueLabel
            // 
            venueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            venueLabel.AutoSize = true;
            venueLabel.Location = new Point(378, 56);
            venueLabel.Name = "venueLabel";
            venueLabel.Size = new Size(75, 15);
            venueLabel.TabIndex = 12;
            venueLabel.Text = "Venue name:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(378, 9);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(107, 15);
            tournamentNameLabel.TabIndex = 11;
            tournamentNameLabel.Text = "Tournament name:";
            // 
            // matchListView
            // 
            matchListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            matchListView.FullRowSelect = true;
            matchListView.GridLines = true;
            matchListView.Location = new Point(12, 12);
            matchListView.MultiSelect = false;
            matchListView.Name = "matchListView";
            matchListView.Size = new Size(350, 337);
            matchListView.TabIndex = 9;
            matchListView.UseCompatibleStateImageBehavior = false;
            matchListView.ItemActivate += MatchListView_ItemActivate;
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tournamentNameTextBox.Location = new Point(378, 27);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(194, 23);
            tournamentNameTextBox.TabIndex = 18;
            // 
            // venueNameTextBox
            // 
            venueNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            venueNameTextBox.Location = new Point(378, 72);
            venueNameTextBox.Name = "venueNameTextBox";
            venueNameTextBox.Size = new Size(194, 23);
            venueNameTextBox.TabIndex = 19;
            // 
            // dateStartLabel
            // 
            dateStartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateStartLabel.Location = new Point(444, 106);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new Size(87, 15);
            dateStartLabel.TabIndex = 20;
            // 
            // dateEndLabel
            // 
            dateEndLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateEndLabel.Location = new Point(444, 130);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new Size(87, 15);
            dateEndLabel.TabIndex = 21;
            // 
            // setStartDateButton
            // 
            setStartDateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setStartDateButton.Location = new Point(537, 102);
            setStartDateButton.Name = "setStartDateButton";
            setStartDateButton.Size = new Size(35, 23);
            setStartDateButton.TabIndex = 22;
            setStartDateButton.Text = "Set";
            setStartDateButton.UseVisualStyleBackColor = true;
            setStartDateButton.Click += SetStartDateButton_Click;
            // 
            // setEndDateButton
            // 
            setEndDateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setEndDateButton.Location = new Point(537, 126);
            setEndDateButton.Name = "setEndDateButton";
            setEndDateButton.Size = new Size(35, 23);
            setEndDateButton.TabIndex = 23;
            setEndDateButton.Text = "Set";
            setEndDateButton.UseVisualStyleBackColor = true;
            setEndDateButton.Click += SetEndDateButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(378, 326);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 23);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // deleteMatchButton
            // 
            deleteMatchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteMatchButton.Location = new Point(378, 208);
            deleteMatchButton.Name = "deleteMatchButton";
            deleteMatchButton.Size = new Size(194, 23);
            deleteMatchButton.TabIndex = 24;
            deleteMatchButton.Text = "Delete selected match";
            deleteMatchButton.UseVisualStyleBackColor = true;
            deleteMatchButton.Click += DeleteMatchButton_Click;
            // 
            // addMatchButton
            // 
            addMatchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addMatchButton.Location = new Point(378, 179);
            addMatchButton.Name = "addMatchButton";
            addMatchButton.Size = new Size(194, 23);
            addMatchButton.TabIndex = 10;
            addMatchButton.Text = "Add match";
            addMatchButton.UseVisualStyleBackColor = true;
            addMatchButton.Click += AddMatchButton_Click;
            // 
            // TournamentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(cancelButton);
            Controls.Add(deleteMatchButton);
            Controls.Add(setEndDateButton);
            Controls.Add(setStartDateButton);
            Controls.Add(dateEndLabel);
            Controls.Add(dateStartLabel);
            Controls.Add(venueNameTextBox);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(venueLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(addMatchButton);
            Controls.Add(matchListView);
            Name = "TournamentEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label idTextLabel;
        private Button saveButton;
        private Label label4;
        private Label label3;
        private Label venueLabel;
        private Label tournamentNameLabel;
        private ListView matchListView;
        private TextBox tournamentNameTextBox;
        private TextBox venueNameTextBox;
        private Label dateStartLabel;
        private Label dateEndLabel;
        private Button setStartDateButton;
        private Button setEndDateButton;
        private Button cancelButton;
        private Button deleteMatchButton;
        private Button addMatchButton;
    }
}