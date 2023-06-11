namespace BadmintonTournamentManager.View.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            entityListView = new ListView();
            imageBox = new PictureBox();
            switchListButton = new Button();
            logOutButton = new Button();
            usernameLabel = new Label();
            label1 = new Label();
            addEntityButton = new Button();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // entityListView
            // 
            entityListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            entityListView.FullRowSelect = true;
            entityListView.GridLines = true;
            entityListView.Location = new Point(453, 12);
            entityListView.MultiSelect = false;
            entityListView.Name = "entityListView";
            entityListView.Size = new Size(335, 426);
            entityListView.TabIndex = 0;
            entityListView.UseCompatibleStateImageBehavior = false;
            entityListView.ItemActivate += ObjectListView_ItemActivate;
            // 
            // imageBox
            // 
            imageBox.Image = (Image)resources.GetObject("imageBox.Image");
            imageBox.InitialImage = null;
            imageBox.Location = new Point(12, 12);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(150, 150);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 1;
            imageBox.TabStop = false;
            // 
            // switchListButton
            // 
            switchListButton.Location = new Point(173, 139);
            switchListButton.Name = "switchListButton";
            switchListButton.Size = new Size(269, 23);
            switchListButton.TabIndex = 2;
            switchListButton.Text = "Switch to other view";
            switchListButton.UseVisualStyleBackColor = true;
            switchListButton.Click += SwitchListButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(175, 63);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 3;
            logOutButton.Text = "Logout";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += LogOutButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoEllipsis = true;
            usernameLabel.Location = new Point(173, 36);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.RightToLeft = RightToLeft.No;
            usernameLabel.Size = new Size(100, 15);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Logged in as:";
            // 
            // addEntityButton
            // 
            addEntityButton.Location = new Point(337, 12);
            addEntityButton.Name = "addEntityButton";
            addEntityButton.Size = new Size(110, 23);
            addEntityButton.TabIndex = 9;
            addEntityButton.Text = "Add Entity";
            addEntityButton.UseVisualStyleBackColor = true;
            addEntityButton.Click += AddEntityButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addEntityButton);
            Controls.Add(label1);
            Controls.Add(usernameLabel);
            Controls.Add(logOutButton);
            Controls.Add(switchListButton);
            Controls.Add(imageBox);
            Controls.Add(entityListView);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Badminton Tournament Manager";
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView entityListView;
        private PictureBox imageBox;
        private Button switchListButton;
        private Button logOutButton;
        private Label usernameLabel;
        private Label label1;
        private Button addEntityButton;
    }
}