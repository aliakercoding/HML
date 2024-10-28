namespace HMLalpha.Views
{
    partial class VendorsControlView
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
            toolStrip1 = new ToolStrip();
            AddNewVendorTool = new ToolStripButton();
            VendorExtraDataTool = new ToolStripDropDownButton();
            VendorCurrentInvoicesTool = new ToolStripMenuItem();
            UpdateCurrentVendorTool = new ToolStripButton();
            DeleteCurrentVendorTool = new ToolStripButton();
            PrintAllVendorsTool = new ToolStripButton();
            VendorSearch = new GroupBox();
            label1 = new Label();
            VendorSearchTextBox = new TextBox();
            VendorIdentifierLabel = new Label();
            VendorsList = new GroupBox();
            VendorsListGridView = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            ContactColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            CreditColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            VendorSearch.SuspendLayout();
            VendorsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VendorsListGridView).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddNewVendorTool, VendorExtraDataTool, UpdateCurrentVendorTool, DeleteCurrentVendorTool, PrintAllVendorsTool });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 150, 0);
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(1312, 52);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddNewVendorTool
            // 
            AddNewVendorTool.Image = Properties.Resources.Add;
            AddNewVendorTool.ImageTransparentColor = Color.Magenta;
            AddNewVendorTool.Name = "AddNewVendorTool";
            AddNewVendorTool.Size = new Size(109, 49);
            AddNewVendorTool.Text = "إضافة مورد جديد";
            AddNewVendorTool.ToolTipText = "إضافة مورد جديد";
            AddNewVendorTool.Click += AddNewVendorTool_Click;
            // 
            // VendorExtraDataTool
            // 
            VendorExtraDataTool.DropDownItems.AddRange(new ToolStripItem[] { VendorCurrentInvoicesTool });
            VendorExtraDataTool.Image = Properties.Resources.ExtraData;
            VendorExtraDataTool.ImageTransparentColor = Color.Magenta;
            VendorExtraDataTool.Name = "VendorExtraDataTool";
            VendorExtraDataTool.Size = new Size(187, 49);
            VendorExtraDataTool.Text = "بيانات إضافية عن المورد الحالي";
            // 
            // VendorCurrentInvoicesTool
            // 
            VendorCurrentInvoicesTool.Name = "VendorCurrentInvoicesTool";
            VendorCurrentInvoicesTool.Size = new Size(135, 22);
            VendorCurrentInvoicesTool.Text = "فواتير المورد";
            VendorCurrentInvoicesTool.ToolTipText = "فواتير المورد";
            // 
            // UpdateCurrentVendorTool
            // 
            UpdateCurrentVendorTool.Image = Properties.Resources.Edit;
            UpdateCurrentVendorTool.ImageTransparentColor = Color.Magenta;
            UpdateCurrentVendorTool.Name = "UpdateCurrentVendorTool";
            UpdateCurrentVendorTool.Size = new Size(155, 49);
            UpdateCurrentVendorTool.Text = "تعديل بيانات المورد الحالي";
            UpdateCurrentVendorTool.Click += UpdateCurrentVendorTool_Click;
            // 
            // DeleteCurrentVendorTool
            // 
            DeleteCurrentVendorTool.Image = Properties.Resources.Delete;
            DeleteCurrentVendorTool.ImageTransparentColor = Color.Magenta;
            DeleteCurrentVendorTool.Name = "DeleteCurrentVendorTool";
            DeleteCurrentVendorTool.Size = new Size(151, 49);
            DeleteCurrentVendorTool.Text = "حذف بيانات المورد الحالي";
            DeleteCurrentVendorTool.Click += DeleteCurrentVendorTool_Click;
            // 
            // PrintAllVendorsTool
            // 
            PrintAllVendorsTool.Image = Properties.Resources.Print;
            PrintAllVendorsTool.ImageTransparentColor = Color.Magenta;
            PrintAllVendorsTool.Name = "PrintAllVendorsTool";
            PrintAllVendorsTool.Size = new Size(163, 49);
            PrintAllVendorsTool.Text = "طباعة تقرير بقائمة الموردين";
            // 
            // VendorSearch
            // 
            VendorSearch.Controls.Add(label1);
            VendorSearch.Controls.Add(VendorSearchTextBox);
            VendorSearch.Controls.Add(VendorIdentifierLabel);
            VendorSearch.Location = new Point(14, 55);
            VendorSearch.Margin = new Padding(4, 3, 4, 3);
            VendorSearch.Name = "VendorSearch";
            VendorSearch.Padding = new Padding(4, 3, 4, 3);
            VendorSearch.RightToLeft = RightToLeft.Yes;
            VendorSearch.Size = new Size(1284, 99);
            VendorSearch.TabIndex = 6;
            VendorSearch.TabStop = false;
            VendorSearch.Text = "البحث عن مورد";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1349, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "كلمة البحث:-";
            // 
            // VendorSearchTextBox
            // 
            VendorSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VendorSearchTextBox.Location = new Point(6, 33);
            VendorSearchTextBox.Margin = new Padding(4, 3, 4, 3);
            VendorSearchTextBox.Name = "VendorSearchTextBox";
            VendorSearchTextBox.PlaceholderText = "برجاء إدخال إسم أو كود المورد";
            VendorSearchTextBox.Size = new Size(1185, 23);
            VendorSearchTextBox.TabIndex = 1;
            VendorSearchTextBox.TextAlign = HorizontalAlignment.Center;
            VendorSearchTextBox.TextChanged += VendorSearchTextBox_TextChanged;
            // 
            // VendorIdentifierLabel
            // 
            VendorIdentifierLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VendorIdentifierLabel.AutoSize = true;
            VendorIdentifierLabel.Location = new Point(1200, 37);
            VendorIdentifierLabel.Margin = new Padding(4, 0, 4, 0);
            VendorIdentifierLabel.Name = "VendorIdentifierLabel";
            VendorIdentifierLabel.Size = new Size(71, 15);
            VendorIdentifierLabel.TabIndex = 0;
            VendorIdentifierLabel.Text = "بيانات البحث:";
            // 
            // VendorsList
            // 
            VendorsList.Controls.Add(VendorsListGridView);
            VendorsList.Location = new Point(14, 162);
            VendorsList.Margin = new Padding(4, 3, 4, 3);
            VendorsList.Name = "VendorsList";
            VendorsList.Padding = new Padding(4, 3, 4, 3);
            VendorsList.RightToLeft = RightToLeft.Yes;
            VendorsList.Size = new Size(1284, 451);
            VendorsList.TabIndex = 7;
            VendorsList.TabStop = false;
            VendorsList.Text = "قائمة الموردين";
            // 
            // VendorsListGridView
            // 
            VendorsListGridView.AllowUserToAddRows = false;
            VendorsListGridView.AllowUserToDeleteRows = false;
            VendorsListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VendorsListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VendorsListGridView.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, ContactColumn, AddressColumn, CreditColumn });
            VendorsListGridView.Dock = DockStyle.Fill;
            VendorsListGridView.Location = new Point(4, 19);
            VendorsListGridView.Margin = new Padding(4, 3, 4, 3);
            VendorsListGridView.MultiSelect = false;
            VendorsListGridView.Name = "VendorsListGridView";
            VendorsListGridView.ReadOnly = true;
            VendorsListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VendorsListGridView.Size = new Size(1276, 429);
            VendorsListGridView.TabIndex = 0;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "مسلسل المورد";
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            IDColumn.Visible = false;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "إسم المورد";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // ContactColumn
            // 
            ContactColumn.HeaderText = "رقم التواصل";
            ContactColumn.Name = "ContactColumn";
            ContactColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "عنوان المورد";
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            // 
            // CreditColumn
            // 
            CreditColumn.HeaderText = "المديونية";
            CreditColumn.Name = "CreditColumn";
            CreditColumn.ReadOnly = true;
            // 
            // VendorsControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 627);
            Controls.Add(VendorsList);
            Controls.Add(VendorSearch);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VendorsControlView";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة المشتريات";
            Activated += VendorsControlView_Activated;
            Load += VendorsControlView_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            VendorSearch.ResumeLayout(false);
            VendorSearch.PerformLayout();
            VendorsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VendorsListGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddNewVendorTool;
        private System.Windows.Forms.ToolStripDropDownButton VendorExtraDataTool;
        private System.Windows.Forms.ToolStripMenuItem VendorCurrentInvoicesTool;
        private System.Windows.Forms.ToolStripButton UpdateCurrentVendorTool;
        private System.Windows.Forms.ToolStripButton DeleteCurrentVendorTool;
        private System.Windows.Forms.ToolStripButton PrintAllVendorsTool;
        private System.Windows.Forms.GroupBox VendorSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VendorSearchTextBox;
        private System.Windows.Forms.Label VendorIdentifierLabel;
        private System.Windows.Forms.GroupBox VendorsList;
        public System.Windows.Forms.DataGridView VendorsListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditColumn;
    }
}