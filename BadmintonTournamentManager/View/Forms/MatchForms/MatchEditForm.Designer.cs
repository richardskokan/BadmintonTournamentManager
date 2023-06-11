namespace BadmintonTournamentManager.View.Forms
{
    partial class MatchEditForm
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
            label1 = new Label();
            player2ScoreLabel = new Label();
            player1ScoreLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            idLabel = new Label();
            idTextLabel = new Label();
            addGameButton = new Button();
            player2NameLabel = new Label();
            player1NameLabel = new Label();
            courtTextBox = new TextBox();
            selectPlayer1Button = new Button();
            selectPlayer2Button = new Button();
            matchNameTextBox = new TextBox();
            label2 = new Label();
            dateTimeLabel = new Label();
            setDateTimeButton = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 7;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player2ScoreLabel
            // 
            player2ScoreLabel.AutoSize = true;
            player2ScoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            player2ScoreLabel.Location = new Point(222, 74);
            player2ScoreLabel.Name = "player2ScoreLabel";
            player2ScoreLabel.Size = new Size(22, 25);
            player2ScoreLabel.TabIndex = 6;
            player2ScoreLabel.Text = "0";
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            player1ScoreLabel.Location = new Point(140, 74);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(22, 25);
            player1ScoreLabel.TabIndex = 5;
            player1ScoreLabel.Text = "0";
            player1ScoreLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(297, 198);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(216, 198);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(39, 202);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 12;
            idLabel.Text = "      ";
            // 
            // idTextLabel
            // 
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(12, 202);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 11;
            idTextLabel.Text = "ID:";
            // 
            // editGameButton
            // 
            addGameButton.Location = new Point(156, 102);
            addGameButton.Name = "editGameButton";
            addGameButton.Size = new Size(75, 23);
            addGameButton.TabIndex = 13;
            addGameButton.Text = "Add Game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += AddGameButton_Click;
            // 
            // player2NameLabel
            // 
            player2NameLabel.Cursor = Cursors.Hand;
            player2NameLabel.Location = new Point(222, 43);
            player2NameLabel.Name = "player2NameLabel";
            player2NameLabel.RightToLeft = RightToLeft.No;
            player2NameLabel.Size = new Size(150, 15);
            player2NameLabel.TabIndex = 15;
            player2NameLabel.Text = "Player 2";
            player2NameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // player1NameLabel
            // 
            player1NameLabel.Cursor = Cursors.Hand;
            player1NameLabel.Location = new Point(12, 43);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(150, 15);
            player1NameLabel.TabIndex = 14;
            player1NameLabel.Text = "Player 1";
            // 
            // courtTextBox
            // 
            courtTextBox.Location = new Point(144, 160);
            courtTextBox.Name = "courtTextBox";
            courtTextBox.Size = new Size(100, 23);
            courtTextBox.TabIndex = 17;
            // 
            // selectPlayer1Button
            // 
            selectPlayer1Button.Location = new Point(12, 61);
            selectPlayer1Button.Name = "selectPlayer1Button";
            selectPlayer1Button.Size = new Size(75, 23);
            selectPlayer1Button.TabIndex = 18;
            selectPlayer1Button.Text = "Select";
            selectPlayer1Button.UseVisualStyleBackColor = true;
            selectPlayer1Button.Click += SelectPlayer1Button_Click;
            // 
            // selectPlayer2Button
            // 
            selectPlayer2Button.Location = new Point(297, 61);
            selectPlayer2Button.Name = "selectPlayer2Button";
            selectPlayer2Button.Size = new Size(75, 23);
            selectPlayer2Button.TabIndex = 19;
            selectPlayer2Button.Text = "Select";
            selectPlayer2Button.UseVisualStyleBackColor = true;
            selectPlayer2Button.Click += SelectPlayer2Button_Click;
            // 
            // matchNameTextBox
            // 
            matchNameTextBox.Location = new Point(133, 12);
            matchNameTextBox.Name = "matchNameTextBox";
            matchNameTextBox.Size = new Size(201, 23);
            matchNameTextBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 15);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 21;
            label2.Text = "Match name:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Location = new Point(144, 134);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(100, 23);
            dateTimeLabel.TabIndex = 22;
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // setDateTimeButton
            // 
            setDateTimeButton.Location = new Point(250, 134);
            setDateTimeButton.Name = "setDateTimeButton";
            setDateTimeButton.Size = new Size(75, 23);
            setDateTimeButton.TabIndex = 23;
            setDateTimeButton.Text = "Set";
            setDateTimeButton.UseVisualStyleBackColor = true;
            setDateTimeButton.Click += SetDateTimeButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 134);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 24;
            label4.Text = "Date and time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 163);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 25;
            label5.Text = "Court name:";
            // 
            // MatchEditForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(384, 233);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(setDateTimeButton);
            Controls.Add(dateTimeLabel);
            Controls.Add(label2);
            Controls.Add(matchNameTextBox);
            Controls.Add(selectPlayer2Button);
            Controls.Add(selectPlayer1Button);
            Controls.Add(courtTextBox);
            Controls.Add(player2NameLabel);
            Controls.Add(player1NameLabel);
            Controls.Add(addGameButton);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(player2ScoreLabel);
            Controls.Add(player1ScoreLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MatchEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Match";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label player2ScoreLabel;
        private Label player1ScoreLabel;
        private Button saveButton;
        private Button cancelButton;
        private Label idLabel;
        private Label idTextLabel;
        private Button addGameButton;
        private Label player2NameLabel;
        private Label player1NameLabel;
        private TextBox courtTextBox;
        private Button selectPlayer1Button;
        private Button selectPlayer2Button;
        private TextBox matchNameTextBox;
        private Label label2;
        private Label dateTimeLabel;
        private Button setDateTimeButton;
        private Label label4;
        private Label label5;
    }
}