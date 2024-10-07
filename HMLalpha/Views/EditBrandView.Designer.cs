namespace HMLalpha.Views
{
    partial class EditBrandView
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
            EditBrandButton = new Button();
            BrandNameTextBox = new TextBox();
            BrandNameLabel = new Label();
            BrandIdLabel = new Label();
            BrandIdTextBox = new TextBox();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(186, 133);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "إلغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditBrandButton
            // 
            EditBrandButton.Location = new Point(353, 133);
            EditBrandButton.Name = "EditBrandButton";
            EditBrandButton.Size = new Size(75, 23);
            EditBrandButton.TabIndex = 10;
            EditBrandButton.Text = "تعديل";
            EditBrandButton.UseVisualStyleBackColor = true;
            EditBrandButton.Click += EditBrandButton_Click;
            // 
            // BrandNameTextBox
            // 
            BrandNameTextBox.Location = new Point(20, 82);
            BrandNameTextBox.Name = "BrandNameTextBox";
            BrandNameTextBox.RightToLeft = RightToLeft.Yes;
            BrandNameTextBox.Size = new Size(489, 23);
            BrandNameTextBox.TabIndex = 8;
            // 
            // BrandNameLabel
            // 
            BrandNameLabel.AutoSize = true;
            BrandNameLabel.Location = new Point(515, 85);
            BrandNameLabel.Name = "BrandNameLabel";
            BrandNameLabel.RightToLeft = RightToLeft.Yes;
            BrandNameLabel.Size = new Size(107, 15);
            BrandNameLabel.TabIndex = 7;
            BrandNameLabel.Text = "إسم العلامة التجارية:";
            // 
            // BrandIdLabel
            // 
            BrandIdLabel.AutoSize = true;
            BrandIdLabel.Location = new Point(515, 33);
            BrandIdLabel.Name = "BrandIdLabel";
            BrandIdLabel.RightToLeft = RightToLeft.Yes;
            BrandIdLabel.Size = new Size(105, 15);
            BrandIdLabel.TabIndex = 7;
            BrandIdLabel.Text = "كود العلامة التجارية:";
            // 
            // BrandIdTextBox
            // 
            BrandIdTextBox.Location = new Point(20, 30);
            BrandIdTextBox.Name = "BrandIdTextBox";
            BrandIdTextBox.ReadOnly = true;
            BrandIdTextBox.RightToLeft = RightToLeft.Yes;
            BrandIdTextBox.Size = new Size(489, 23);
            BrandIdTextBox.TabIndex = 8;
            BrandIdTextBox.TextChanged += BrandIdTextBox_TextChanged;
            // 
            // EditBrandView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 181);
            Controls.Add(CancelButton);
            Controls.Add(EditBrandButton);
            Controls.Add(BrandIdTextBox);
            Controls.Add(BrandNameTextBox);
            Controls.Add(BrandIdLabel);
            Controls.Add(BrandNameLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditBrandView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تعديل بيانات العلامة التجارية";
            Load += EditBrandView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button EditBrandButton;
        private TextBox BrandNameTextBox;
        private Label BrandNameLabel;
        private Label BrandIdLabel;
        private TextBox BrandIdTextBox;
    }
}