namespace HMLalpha.Views
{
    partial class AddNewCatalogView
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
            CatalogNameLabel = new Label();
            CatalogNameTextBox = new TextBox();
            AddCatalogButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // CatalogNameLabel
            // 
            CatalogNameLabel.AutoSize = true;
            CatalogNameLabel.Location = new Point(542, 43);
            CatalogNameLabel.Name = "CatalogNameLabel";
            CatalogNameLabel.RightToLeft = RightToLeft.Yes;
            CatalogNameLabel.Size = new Size(71, 15);
            CatalogNameLabel.TabIndex = 0;
            CatalogNameLabel.Text = "إسم الكتالوج:";
            // 
            // CatalogNameTextBox
            // 
            CatalogNameTextBox.Location = new Point(25, 40);
            CatalogNameTextBox.Name = "CatalogNameTextBox";
            CatalogNameTextBox.RightToLeft = RightToLeft.Yes;
            CatalogNameTextBox.Size = new Size(511, 23);
            CatalogNameTextBox.TabIndex = 1;
            // 
            // AddCatalogButton
            // 
            AddCatalogButton.Location = new Point(358, 113);
            AddCatalogButton.Name = "AddCatalogButton";
            AddCatalogButton.Size = new Size(75, 23);
            AddCatalogButton.TabIndex = 2;
            AddCatalogButton.Text = "إضافة";
            AddCatalogButton.UseVisualStyleBackColor = true;
            AddCatalogButton.Click += AddCatalogButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(191, 113);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "إلغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddNewCatalogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 177);
            Controls.Add(CancelButton);
            Controls.Add(AddCatalogButton);
            Controls.Add(CatalogNameTextBox);
            Controls.Add(CatalogNameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewCatalogView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إضافة كتالوج جديد";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CatalogNameLabel;
        private TextBox CatalogNameTextBox;
        private Button AddCatalogButton;
        private new Button CancelButton;
    }
}