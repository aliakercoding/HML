namespace HMLalpha.Views
{
    partial class ItemExpiryView
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
            ItemExpiryGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ItemExpiryGridView).BeginInit();
            SuspendLayout();
            // 
            // ItemExpiryGridView
            // 
            ItemExpiryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemExpiryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemExpiryGridView.Dock = DockStyle.Fill;
            ItemExpiryGridView.Location = new Point(0, 0);
            ItemExpiryGridView.MultiSelect = false;
            ItemExpiryGridView.Name = "ItemExpiryGridView";
            ItemExpiryGridView.RightToLeft = RightToLeft.Yes;
            ItemExpiryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemExpiryGridView.Size = new Size(1098, 398);
            ItemExpiryGridView.TabIndex = 0;
            // 
            // ItemExpiryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 398);
            Controls.Add(ItemExpiryGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemExpiryView";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تاريخ صلاحية الصنف";
            ((System.ComponentModel.ISupportInitialize)ItemExpiryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView ItemExpiryGridView;
    }
}