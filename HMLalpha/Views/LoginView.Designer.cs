namespace HMLalpha.Views
{
    partial class LoginView
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
            LoginButton = new Button();
            UserNameLabel = new Label();
            UserNameTextbox = new TextBox();
            UserPasscodeLabel = new Label();
            UserPasscodeTextbox = new TextBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(359, 207);
            LoginButton.Margin = new Padding(4, 3, 4, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(88, 27);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "دخول";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(539, 81);
            UserNameLabel.Margin = new Padding(4, 0, 4, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.RightToLeft = RightToLeft.Yes;
            UserNameLabel.Size = new Size(81, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "إسم المستخدم:";
            // 
            // UserNameTextbox
            // 
            UserNameTextbox.Location = new Point(14, 77);
            UserNameTextbox.Margin = new Padding(4, 3, 4, 3);
            UserNameTextbox.Name = "UserNameTextbox";
            UserNameTextbox.Size = new Size(517, 23);
            UserNameTextbox.TabIndex = 2;
            // 
            // UserPasscodeLabel
            // 
            UserPasscodeLabel.AutoSize = true;
            UserPasscodeLabel.Location = new Point(555, 141);
            UserPasscodeLabel.Margin = new Padding(4, 0, 4, 0);
            UserPasscodeLabel.Name = "UserPasscodeLabel";
            UserPasscodeLabel.RightToLeft = RightToLeft.Yes;
            UserPasscodeLabel.Size = new Size(65, 15);
            UserPasscodeLabel.TabIndex = 1;
            UserPasscodeLabel.Text = "كلمة المرور:";
            // 
            // UserPasscodeTextbox
            // 
            UserPasscodeTextbox.Location = new Point(14, 138);
            UserPasscodeTextbox.Margin = new Padding(4, 3, 4, 3);
            UserPasscodeTextbox.Name = "UserPasscodeTextbox";
            UserPasscodeTextbox.Size = new Size(517, 23);
            UserPasscodeTextbox.TabIndex = 2;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(138, 207);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(88, 27);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "إغلاق";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 285);
            Controls.Add(UserPasscodeTextbox);
            Controls.Add(UserNameTextbox);
            Controls.Add(UserPasscodeLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(CloseButton);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.Label UserPasscodeLabel;
        private System.Windows.Forms.TextBox UserPasscodeTextbox;
        private System.Windows.Forms.Button CloseButton;
    }
}