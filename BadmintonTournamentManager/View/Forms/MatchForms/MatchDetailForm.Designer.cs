namespace BadmintonTournamentManager.View.Forms
{
    partial class MatchDetailForm
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
            player1NameLabel = new Label();
            player2NameLabel = new Label();
            player1ScoreLabel = new Label();
            player2ScoreLabel = new Label();
            label1 = new Label();
            dateTimeLabel = new Label();
            courtLabel = new Label();
            gameListLabel = new Label();
            editButton = new Button();
            idLabel = new Label();
            idTextLabel = new Label();
            matchNameLabel = new Label();
            SuspendLayout();
            // 
            // player1NameLabel
            // 
            player1NameLabel.Cursor = Cursors.Hand;
            player1NameLabel.Location = new Point(12, 43);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(150, 15);
            player1NameLabel.TabIndex = 0;
            player1NameLabel.Text = "player 1 name";
            player1NameLabel.Click += Player1NameLabel_Click;
            // 
            // player2NameLabel
            // 
            player2NameLabel.Cursor = Cursors.Hand;
            player2NameLabel.Location = new Point(222, 43);
            player2NameLabel.Name = "player2NameLabel";
            player2NameLabel.RightToLeft = RightToLeft.No;
            player2NameLabel.Size = new Size(150, 15);
            player2NameLabel.TabIndex = 1;
            player2NameLabel.Text = "player 2 name";
            player2NameLabel.TextAlign = ContentAlignment.TopRight;
            player2NameLabel.Click += Player2NameLabel_Click;
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            player1ScoreLabel.Location = new Point(140, 74);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(22, 25);
            player1ScoreLabel.TabIndex = 2;
            player1ScoreLabel.Text = "0";
            player1ScoreLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // player2ScoreLabel
            // 
            player2ScoreLabel.AutoSize = true;
            player2ScoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            player2ScoreLabel.Location = new Point(222, 74);
            player2ScoreLabel.Name = "player2ScoreLabel";
            player2ScoreLabel.Size = new Size(22, 25);
            player2ScoreLabel.TabIndex = 3;
            player2ScoreLabel.Text = "0";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 4;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Location = new Point(140, 151);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(104, 23);
            dateTimeLabel.TabIndex = 5;
            dateTimeLabel.Text = "Date and time";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // courtLabel
            // 
            courtLabel.Location = new Point(140, 174);
            courtLabel.Name = "courtLabel";
            courtLabel.Size = new Size(104, 23);
            courtLabel.TabIndex = 6;
            courtLabel.Text = "Venue court";
            courtLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameListLabel
            // 
            gameListLabel.Location = new Point(12, 110);
            gameListLabel.Name = "gameListLabel";
            gameListLabel.Size = new Size(360, 23);
            gameListLabel.TabIndex = 7;
            gameListLabel.Text = "(-:-, -:-, -:-)";
            gameListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            editButton.Location = new Point(297, 198);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(39, 202);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 10;
            idLabel.Text = "      ";
            // 
            // idTextLabel
            // 
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(12, 202);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 9;
            idTextLabel.Text = "ID:";
            // 
            // matchNameLabel
            // 
            matchNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            matchNameLabel.Location = new Point(12, 9);
            matchNameLabel.Name = "matchNameLabel";
            matchNameLabel.Size = new Size(360, 30);
            matchNameLabel.TabIndex = 11;
            matchNameLabel.Text = "Match name";
            matchNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MatchDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 233);
            Controls.Add(matchNameLabel);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(editButton);
            Controls.Add(gameListLabel);
            Controls.Add(courtLabel);
            Controls.Add(dateTimeLabel);
            Controls.Add(label1);
            Controls.Add(player2ScoreLabel);
            Controls.Add(player1ScoreLabel);
            Controls.Add(player2NameLabel);
            Controls.Add(player1NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MatchDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Match Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label player1NameLabel;
        private Label player2NameLabel;
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;
        private Label label1;
        private Label dateTimeLabel;
        private Label courtLabel;
        private Label gameListLabel;
        private Button editButton;
        private Label idLabel;
        private Label idTextLabel;
        private Label matchNameLabel;
    }
}