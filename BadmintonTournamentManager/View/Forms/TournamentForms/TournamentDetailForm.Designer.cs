namespace BadmintonTournamentManager.View.Forms
{
    partial class TournamentDetailForm
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
            matchListView = new ListView();
            generateTreeButton = new Button();
            tournamentNameLabel = new Label();
            venueLabel = new Label();
            dateStartLabel = new Label();
            dateEndLabel = new Label();
            editButton = new Button();
            idTextLabel = new Label();
            idLabel = new Label();
            SuspendLayout();
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
            matchListView.TabIndex = 0;
            matchListView.UseCompatibleStateImageBehavior = false;
            matchListView.ItemActivate += MatchListView_ItemActivate;
            // 
            // generateTreeButton
            // 
            generateTreeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generateTreeButton.Location = new Point(378, 326);
            generateTreeButton.Name = "generateTreeButton";
            generateTreeButton.Size = new Size(194, 23);
            generateTreeButton.TabIndex = 1;
            generateTreeButton.Text = "Generate match tree";
            generateTreeButton.UseVisualStyleBackColor = true;
            generateTreeButton.Click += generateTreeButton_Click;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(378, 12);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(136, 21);
            tournamentNameLabel.TabIndex = 2;
            tournamentNameLabel.Text = "Tournament name";
            // 
            // venueLabel
            // 
            venueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            venueLabel.AutoSize = true;
            venueLabel.Location = new Point(378, 56);
            venueLabel.Name = "venueLabel";
            venueLabel.Size = new Size(72, 15);
            venueLabel.TabIndex = 3;
            venueLabel.Text = "Venue name";
            // 
            // dateStartLabel
            // 
            dateStartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new Point(378, 98);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new Size(57, 15);
            dateStartLabel.TabIndex = 4;
            dateStartLabel.Text = "Date start";
            // 
            // dateEndLabel
            // 
            dateEndLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateEndLabel.AutoSize = true;
            dateEndLabel.Location = new Point(378, 122);
            dateEndLabel.Name = "dateEndLabel";
            dateEndLabel.Size = new Size(54, 15);
            dateEndLabel.TabIndex = 5;
            dateEndLabel.Text = "Date end";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(497, 297);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // idTextLabel
            // 
            idTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(378, 301);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 7;
            idTextLabel.Text = "ID:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(405, 301);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "      ";
            // 
            // TournamentDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(editButton);
            Controls.Add(dateEndLabel);
            Controls.Add(dateStartLabel);
            Controls.Add(venueLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(generateTreeButton);
            Controls.Add(matchListView);
            MaximizeBox = false;
            Name = "TournamentDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TournamentDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView matchListView;
        private Button generateTreeButton;
        private Label tournamentNameLabel;
        private Label venueLabel;
        private Label dateStartLabel;
        private Label dateEndLabel;
        private Button editButton;
        private Label idTextLabel;
        private Label idLabel;
    }
}