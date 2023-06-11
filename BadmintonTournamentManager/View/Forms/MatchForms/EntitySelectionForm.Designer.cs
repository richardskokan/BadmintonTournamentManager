namespace BadmintonTournamentManager.View.Forms
{
    partial class EntitySelectionForm
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
            selectButton = new Button();
            entitiesListView = new ListView();
            changeSelectListButton = new Button();
            SuspendLayout();
            // 
            // selectButton
            // 
            selectButton.Location = new Point(247, 326);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(75, 23);
            selectButton.TabIndex = 0;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += SelectButton_Click;
            // 
            // entitiesListView
            // 
            entitiesListView.FullRowSelect = true;
            entitiesListView.GridLines = true;
            entitiesListView.Location = new Point(12, 12);
            entitiesListView.Name = "entitiesListView";
            entitiesListView.Size = new Size(310, 308);
            entitiesListView.TabIndex = 1;
            entitiesListView.UseCompatibleStateImageBehavior = false;
            entitiesListView.ItemActivate += EntitiesListView_ItemActivate;
            // 
            // changeSelectListButton
            // 
            changeSelectListButton.Location = new Point(12, 326);
            changeSelectListButton.Name = "changeSelectListButton";
            changeSelectListButton.Size = new Size(150, 23);
            changeSelectListButton.TabIndex = 2;
            changeSelectListButton.Text = "Select from ...";
            changeSelectListButton.UseVisualStyleBackColor = true;
            changeSelectListButton.Click += ChangeSelectListButton_Click;
            // 
            // EntitySelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(changeSelectListButton);
            Controls.Add(entitiesListView);
            Controls.Add(selectButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EntitySelectionForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Button selectButton;
        private ListView entitiesListView;
        private Button changeSelectListButton;
    }
}