namespace BadmintonTournamentManager.View.Forms.MatchForms
{
    partial class AddGameForm
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
            player2NameLabel = new Label();
            player1NameLabel = new Label();
            player1ScoreNumeric = new NumericUpDown();
            player2ScoreNumeric = new NumericUpDown();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)player1ScoreNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2ScoreNumeric).BeginInit();
            SuspendLayout();
            // 
            // player2NameLabel
            // 
            player2NameLabel.Cursor = Cursors.Hand;
            player2NameLabel.Location = new Point(172, 9);
            player2NameLabel.Name = "player2NameLabel";
            player2NameLabel.RightToLeft = RightToLeft.No;
            player2NameLabel.Size = new Size(100, 15);
            player2NameLabel.TabIndex = 17;
            player2NameLabel.Text = "Player 2";
            player2NameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // player1NameLabel
            // 
            player1NameLabel.Cursor = Cursors.Hand;
            player1NameLabel.Location = new Point(12, 9);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(100, 15);
            player1NameLabel.TabIndex = 16;
            player1NameLabel.Text = "Player 1";
            // 
            // player1ScoreNumeric
            // 
            player1ScoreNumeric.Location = new Point(12, 36);
            player1ScoreNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            player1ScoreNumeric.Name = "player1ScoreNumeric";
            player1ScoreNumeric.Size = new Size(100, 23);
            player1ScoreNumeric.TabIndex = 18;
            player1ScoreNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // player2ScoreNumeric
            // 
            player2ScoreNumeric.Location = new Point(172, 36);
            player2ScoreNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            player2ScoreNumeric.Name = "player2ScoreNumeric";
            player2ScoreNumeric.Size = new Size(100, 23);
            player2ScoreNumeric.TabIndex = 19;
            player2ScoreNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(172, 76);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 76);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 23);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(player2ScoreNumeric);
            Controls.Add(player1ScoreNumeric);
            Controls.Add(player2NameLabel);
            Controls.Add(player1NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddGameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add game";
            ((System.ComponentModel.ISupportInitialize)player1ScoreNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2ScoreNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label player2NameLabel;
        private Label player1NameLabel;
        private NumericUpDown player1ScoreNumeric;
        private NumericUpDown player2ScoreNumeric;
        private Button saveButton;
        private Button cancelButton;
    }
}