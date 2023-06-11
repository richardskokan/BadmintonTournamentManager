namespace BadmintonTournamentManager.View.Forms
{
    partial class PlayerDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDetailForm));
            playerPictureBox = new PictureBox();
            surnameLabel = new Label();
            firstnameLabel = new Label();
            birthdayLabel = new Label();
            nationalityLabel = new Label();
            label1 = new Label();
            informationLabel = new Label();
            editButton = new Button();
            idLabel = new Label();
            idTextLabel = new Label();
            statisticsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = (Image)resources.GetObject("playerPictureBox.Image");
            playerPictureBox.Location = new Point(12, 12);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(150, 150);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 0;
            playerPictureBox.TabStop = false;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            surnameLabel.Location = new Point(187, 12);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(95, 30);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstnameLabel.Location = new Point(187, 52);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(79, 21);
            firstnameLabel.TabIndex = 2;
            firstnameLabel.Text = "Firstname";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(187, 99);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(67, 15);
            birthdayLabel.TabIndex = 3;
            birthdayLabel.Text = "00. 00. 0000";
            // 
            // nationalityLabel
            // 
            nationalityLabel.AutoSize = true;
            nationalityLabel.Location = new Point(187, 128);
            nationalityLabel.Name = "nationalityLabel";
            nationalityLabel.Size = new Size(63, 15);
            nationalityLabel.TabIndex = 4;
            nationalityLabel.Text = "nationality";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "Bio:";
            // 
            // informationLabel
            // 
            informationLabel.Location = new Point(12, 197);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(410, 167);
            informationLabel.TabIndex = 6;
            informationLabel.Text = resources.GetString("informationLabel.Text");
            // 
            // editButton
            // 
            editButton.Location = new Point(266, 376);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(39, 380);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 10;
            idLabel.Text = "      ";
            // 
            // idTextLabel
            // 
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(12, 380);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 9;
            idTextLabel.Text = "ID:";
            // 
            // statisticsButton
            // 
            statisticsButton.Location = new Point(347, 376);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(75, 23);
            statisticsButton.TabIndex = 11;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += StatisticsButton_Click;
            // 
            // PlayerDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(statisticsButton);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(editButton);
            Controls.Add(informationLabel);
            Controls.Add(label1);
            Controls.Add(nationalityLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(surnameLabel);
            Controls.Add(playerPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PlayerDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Player Detail";
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox playerPictureBox;
        private Label surnameLabel;
        private Label firstnameLabel;
        private Label birthdayLabel;
        private Label nationalityLabel;
        private Label label1;
        private Label informationLabel;
        private Button editButton;
        private Label idLabel;
        private Label idTextLabel;
        private Button statisticsButton;
    }
}