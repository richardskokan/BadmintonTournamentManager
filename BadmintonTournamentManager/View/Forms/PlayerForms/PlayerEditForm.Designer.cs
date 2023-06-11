namespace BadmintonTournamentManager.View.Forms
{
    partial class PlayerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerEditForm));
            playerPictureBox = new PictureBox();
            label1 = new Label();
            idLabel = new Label();
            idTextLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            informationTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            nationalityTextBox = new TextBox();
            openDatePickerButton = new Button();
            birthDateLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            playerPictureBox.TabIndex = 1;
            playerPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "Bio:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(39, 380);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 15);
            idLabel.TabIndex = 12;
            idLabel.Text = "      ";
            // 
            // idTextLabel
            // 
            idTextLabel.AutoSize = true;
            idTextLabel.Location = new Point(12, 380);
            idTextLabel.Name = "idTextLabel";
            idTextLabel.Size = new Size(21, 15);
            idTextLabel.TabIndex = 11;
            idTextLabel.Text = "ID:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(347, 376);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(266, 376);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // informationTextBox
            // 
            informationTextBox.Location = new Point(12, 200);
            informationTextBox.Multiline = true;
            informationTextBox.Name = "informationTextBox";
            informationTextBox.Size = new Size(410, 170);
            informationTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(250, 23);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(172, 23);
            lastNameTextBox.TabIndex = 16;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(250, 52);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(172, 23);
            firstNameTextBox.TabIndex = 17;
            // 
            // nationalityTextBox
            // 
            nationalityTextBox.Location = new Point(250, 128);
            nationalityTextBox.Name = "nationalityTextBox";
            nationalityTextBox.Size = new Size(172, 23);
            nationalityTextBox.TabIndex = 19;
            // 
            // openDatePickerButton
            // 
            openDatePickerButton.Location = new Point(356, 102);
            openDatePickerButton.Name = "openDatePickerButton";
            openDatePickerButton.Size = new Size(66, 23);
            openDatePickerButton.TabIndex = 20;
            openDatePickerButton.Text = "Set";
            openDatePickerButton.UseVisualStyleBackColor = true;
            openDatePickerButton.Click += OpenDatePickerButton_Click;
            // 
            // birthDateLabel
            // 
            birthDateLabel.Location = new Point(250, 102);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(100, 23);
            birthDateLabel.TabIndex = 21;
            birthDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 26);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 22;
            label2.Text = "Surname:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 55);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 23;
            label3.Text = "Firstname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 106);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 24;
            label4.Text = "Date of birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 131);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 25;
            label5.Text = "Nationality:";
            // 
            // PlayerEditForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(434, 411);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(birthDateLabel);
            Controls.Add(openDatePickerButton);
            Controls.Add(nationalityTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(informationTextBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(idLabel);
            Controls.Add(idTextLabel);
            Controls.Add(label1);
            Controls.Add(playerPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PlayerEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Player";
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox playerPictureBox;
        private Label label1;
        private Label idLabel;
        private Label idTextLabel;
        private Button saveButton;
        private Button cancelButton;
        private TextBox informationTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox nationalityTextBox;
        private Button openDatePickerButton;
        private Label birthDateLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}