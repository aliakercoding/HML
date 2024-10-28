namespace HMLalpha.Views
{
    partial class EditVendorView
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
            VendorBasicDataGP = new GroupBox();
            VendorAddressTextArea = new TextBox();
            VendorContactTextBox = new TextBox();
            VendorNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            VendorFinancialsGP = new GroupBox();
            VendorInvoicesTextBox = new TextBox();
            VendorCreditTextBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            CancelButton = new Button();
            EditVendorButton = new Button();
            VendorBasicDataGP.SuspendLayout();
            VendorFinancialsGP.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // VendorBasicDataGP
            // 
            VendorBasicDataGP.Controls.Add(VendorAddressTextArea);
            VendorBasicDataGP.Controls.Add(VendorContactTextBox);
            VendorBasicDataGP.Controls.Add(VendorNameTextBox);
            VendorBasicDataGP.Controls.Add(label4);
            VendorBasicDataGP.Controls.Add(label3);
            VendorBasicDataGP.Controls.Add(label1);
            VendorBasicDataGP.Location = new Point(16, 16);
            VendorBasicDataGP.Margin = new Padding(4, 3, 4, 3);
            VendorBasicDataGP.Name = "VendorBasicDataGP";
            VendorBasicDataGP.Padding = new Padding(4, 3, 4, 3);
            VendorBasicDataGP.RightToLeft = RightToLeft.Yes;
            VendorBasicDataGP.Size = new Size(659, 284);
            VendorBasicDataGP.TabIndex = 2;
            VendorBasicDataGP.TabStop = false;
            VendorBasicDataGP.Text = "بيانات المورد الأساسية:";
            // 
            // VendorAddressTextArea
            // 
            VendorAddressTextArea.Location = new Point(22, 192);
            VendorAddressTextArea.Margin = new Padding(4, 3, 4, 3);
            VendorAddressTextArea.Multiline = true;
            VendorAddressTextArea.Name = "VendorAddressTextArea";
            VendorAddressTextArea.Size = new Size(526, 69);
            VendorAddressTextArea.TabIndex = 1;
            // 
            // VendorContactTextBox
            // 
            VendorContactTextBox.Location = new Point(22, 119);
            VendorContactTextBox.Margin = new Padding(4, 3, 4, 3);
            VendorContactTextBox.Name = "VendorContactTextBox";
            VendorContactTextBox.Size = new Size(536, 23);
            VendorContactTextBox.TabIndex = 1;
            // 
            // VendorNameTextBox
            // 
            VendorNameTextBox.Location = new Point(22, 81);
            VendorNameTextBox.Margin = new Padding(4, 3, 4, 3);
            VendorNameTextBox.Name = "VendorNameTextBox";
            VendorNameTextBox.Size = new Size(536, 23);
            VendorNameTextBox.TabIndex = 1;
            VendorNameTextBox.TextChanged += VendorNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 0;
            label4.Text = "عنوان التواصل:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "رقم التواصل:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "إسم المورد:";
            // 
            // VendorFinancialsGP
            // 
            VendorFinancialsGP.Controls.Add(VendorInvoicesTextBox);
            VendorFinancialsGP.Controls.Add(VendorCreditTextBox);
            VendorFinancialsGP.Controls.Add(label5);
            VendorFinancialsGP.Controls.Add(label2);
            VendorFinancialsGP.Location = new Point(16, 307);
            VendorFinancialsGP.Margin = new Padding(4, 3, 4, 3);
            VendorFinancialsGP.Name = "VendorFinancialsGP";
            VendorFinancialsGP.Padding = new Padding(4, 3, 4, 3);
            VendorFinancialsGP.RightToLeft = RightToLeft.Yes;
            VendorFinancialsGP.Size = new Size(659, 216);
            VendorFinancialsGP.TabIndex = 3;
            VendorFinancialsGP.TabStop = false;
            VendorFinancialsGP.Text = "المتعلقات المالية:";
            // 
            // VendorInvoicesTextBox
            // 
            VendorInvoicesTextBox.Location = new Point(22, 121);
            VendorInvoicesTextBox.Margin = new Padding(4, 3, 4, 3);
            VendorInvoicesTextBox.Name = "VendorInvoicesTextBox";
            VendorInvoicesTextBox.ReadOnly = true;
            VendorInvoicesTextBox.Size = new Size(486, 23);
            VendorInvoicesTextBox.TabIndex = 1;
            VendorInvoicesTextBox.Text = "0";
            // 
            // VendorCreditTextBox
            // 
            VendorCreditTextBox.Location = new Point(22, 68);
            VendorCreditTextBox.Margin = new Padding(4, 3, 4, 3);
            VendorCreditTextBox.Name = "VendorCreditTextBox";
            VendorCreditTextBox.ReadOnly = true;
            VendorCreditTextBox.Size = new Size(554, 23);
            VendorCreditTextBox.TabIndex = 1;
            VendorCreditTextBox.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 0;
            label5.Text = "عدد الفواتير المشتراه:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "المديونية:";
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(EditVendorButton);
            panel1.Location = new Point(16, 530);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 67);
            panel1.TabIndex = 4;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(224, 21);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "إلغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditVendorButton
            // 
            EditVendorButton.Location = new Point(346, 21);
            EditVendorButton.Margin = new Padding(4, 3, 4, 3);
            EditVendorButton.Name = "EditVendorButton";
            EditVendorButton.Size = new Size(88, 27);
            EditVendorButton.TabIndex = 0;
            EditVendorButton.Text = "تعديل";
            EditVendorButton.UseVisualStyleBackColor = true;
            EditVendorButton.Click += EditVendorButton_Click;
            // 
            // EditVendorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 613);
            Controls.Add(VendorBasicDataGP);
            Controls.Add(VendorFinancialsGP);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditVendorView";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تعديل بيانات المورد";
            Load += EditVendorView_Load;
            VendorBasicDataGP.ResumeLayout(false);
            VendorBasicDataGP.PerformLayout();
            VendorFinancialsGP.ResumeLayout(false);
            VendorFinancialsGP.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox VendorBasicDataGP;
        private System.Windows.Forms.TextBox VendorAddressTextArea;
        private System.Windows.Forms.TextBox VendorContactTextBox;
        private System.Windows.Forms.TextBox VendorNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox VendorFinancialsGP;
        private System.Windows.Forms.TextBox VendorInvoicesTextBox;
        private System.Windows.Forms.TextBox VendorCreditTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditVendorButton;
    }
}