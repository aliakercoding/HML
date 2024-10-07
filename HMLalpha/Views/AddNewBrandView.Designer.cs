namespace HMLalpha.Views
{
    partial class AddNewBrandView
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
            CancelButton = new Button();
            AddBrandButton = new Button();
            BrandNameTextBox = new TextBox();
            BrandNameLabel = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(191, 113);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "إلغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddBrandButton
            // 
            AddBrandButton.Location = new Point(358, 113);
            AddBrandButton.Name = "AddBrandButton";
            AddBrandButton.Size = new Size(75, 23);
            AddBrandButton.TabIndex = 6;
            AddBrandButton.Text = "إضافة";
            AddBrandButton.UseVisualStyleBackColor = true;
            AddBrandButton.Click += AddBrandButton_Click;
            // 
            // BrandNameTextBox
            // 
            BrandNameTextBox.Location = new Point(25, 40);
            BrandNameTextBox.Name = "BrandNameTextBox";
            BrandNameTextBox.RightToLeft = RightToLeft.Yes;
            BrandNameTextBox.Size = new Size(489, 23);
            BrandNameTextBox.TabIndex = 4;
            // 
            // BrandNameLabel
            // 
            BrandNameLabel.AutoSize = true;
            BrandNameLabel.Location = new Point(520, 43);
            BrandNameLabel.Name = "BrandNameLabel";
            BrandNameLabel.RightToLeft = RightToLeft.Yes;
            BrandNameLabel.Size = new Size(107, 15);
            BrandNameLabel.TabIndex = 3;
            BrandNameLabel.Text = "إسم العلامة التجارية:";
            // 
            // AddNewBrandView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 177);
            Controls.Add(CancelButton);
            Controls.Add(AddBrandButton);
            Controls.Add(BrandNameTextBox);
            Controls.Add(BrandNameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewBrandView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إضافة علامة تجارية جديدة";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private new Button CancelButton;
        private Button AddBrandButton;
        private TextBox BrandNameTextBox;
        private Label BrandNameLabel;
    }
}