namespace HMLalpha.Views
{
    partial class AddNewSectionView
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
            AddSectionButton = new Button();
            SectionNameTextBox = new TextBox();
            SectionNameLabel = new Label();
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
            // AddSectionButton
            // 
            AddSectionButton.Location = new Point(358, 113);
            AddSectionButton.Name = "AddSectionButton";
            AddSectionButton.Size = new Size(75, 23);
            AddSectionButton.TabIndex = 6;
            AddSectionButton.Text = "إضافة";
            AddSectionButton.UseVisualStyleBackColor = true;
            AddSectionButton.Click += AddSectionButton_Click;
            // 
            // SectionNameTextBox
            // 
            SectionNameTextBox.Location = new Point(25, 40);
            SectionNameTextBox.Name = "SectionNameTextBox";
            SectionNameTextBox.RightToLeft = RightToLeft.Yes;
            SectionNameTextBox.Size = new Size(511, 23);
            SectionNameTextBox.TabIndex = 4;
            // 
            // SectionNameLabel
            // 
            SectionNameLabel.AutoSize = true;
            SectionNameLabel.Location = new Point(542, 43);
            SectionNameLabel.Name = "SectionNameLabel";
            SectionNameLabel.RightToLeft = RightToLeft.Yes;
            SectionNameLabel.Size = new Size(63, 15);
            SectionNameLabel.TabIndex = 3;
            SectionNameLabel.Text = "إسم القسم:";
            // 
            // AddNewSectionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 177);
            Controls.Add(CancelButton);
            Controls.Add(AddSectionButton);
            Controls.Add(SectionNameTextBox);
            Controls.Add(SectionNameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewSectionView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إضافة قسم جديد";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private new Button CancelButton;
        private Button AddSectionButton;
        private TextBox SectionNameTextBox;
        private Label SectionNameLabel;
    }
}