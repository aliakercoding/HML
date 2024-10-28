namespace HMLalpha.Views
{
    partial class ItemsControlView
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
            ItemsList = new GroupBox();
            ItemsListGridView = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            BarcodeColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            RetailPriceColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            CatalogRelatedColumn = new DataGridViewTextBoxColumn();
            SectionRelatedColumn = new DataGridViewTextBoxColumn();
            BrandRelatedColumn = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            AddNewItemTool = new ToolStripButton();
            ItemExtraDataTool = new ToolStripDropDownButton();
            CurrentItemExpiryTool = new ToolStripMenuItem();
            CurrentItemPhoto = new ToolStripMenuItem();
            UpdateCurrentItemTool = new ToolStripButton();
            DeleteCurrentItemTool = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            ItemSearch = new GroupBox();
            ItemSearchTextBox = new TextBox();
            ItemIdentifierLabel = new Label();
            ItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsListGridView).BeginInit();
            toolStrip1.SuspendLayout();
            ItemSearch.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsList
            // 
            ItemsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsList.Controls.Add(ItemsListGridView);
            ItemsList.Location = new Point(0, 168);
            ItemsList.Name = "ItemsList";
            ItemsList.RightToLeft = RightToLeft.Yes;
            ItemsList.Size = new Size(1131, 471);
            ItemsList.TabIndex = 3;
            ItemsList.TabStop = false;
            ItemsList.Text = "قائمة الأصناف";
            // 
            // ItemsListGridView
            // 
            ItemsListGridView.AllowUserToAddRows = false;
            ItemsListGridView.AllowUserToDeleteRows = false;
            ItemsListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemsListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsListGridView.Columns.AddRange(new DataGridViewColumn[] { IDColumn, BarcodeColumn, NameColumn, RetailPriceColumn, QuantityColumn, CatalogRelatedColumn, SectionRelatedColumn, BrandRelatedColumn });
            ItemsListGridView.Dock = DockStyle.Fill;
            ItemsListGridView.Location = new Point(3, 19);
            ItemsListGridView.MultiSelect = false;
            ItemsListGridView.Name = "ItemsListGridView";
            ItemsListGridView.ReadOnly = true;
            ItemsListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsListGridView.Size = new Size(1125, 449);
            ItemsListGridView.TabIndex = 0;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "مسلسل الصنف";
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            IDColumn.Visible = false;
            // 
            // BarcodeColumn
            // 
            BarcodeColumn.HeaderText = "باركود الصنف";
            BarcodeColumn.Name = "BarcodeColumn";
            BarcodeColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "إسم الصنف";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // RetailPriceColumn
            // 
            RetailPriceColumn.HeaderText = "سعر بيع الصنف";
            RetailPriceColumn.Name = "RetailPriceColumn";
            RetailPriceColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            QuantityColumn.HeaderText = "الكمية المتاحة من الصنف";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // CatalogRelatedColumn
            // 
            CatalogRelatedColumn.HeaderText = "تابع لكتالوج";
            CatalogRelatedColumn.Name = "CatalogRelatedColumn";
            CatalogRelatedColumn.ReadOnly = true;
            // 
            // SectionRelatedColumn
            // 
            SectionRelatedColumn.HeaderText = "تابع لقسم";
            SectionRelatedColumn.Name = "SectionRelatedColumn";
            SectionRelatedColumn.ReadOnly = true;
            // 
            // BrandRelatedColumn
            // 
            BrandRelatedColumn.HeaderText = "تابع للعلامة التجارية";
            BrandRelatedColumn.Name = "BrandRelatedColumn";
            BrandRelatedColumn.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddNewItemTool, ItemExtraDataTool, UpdateCurrentItemTool, DeleteCurrentItemTool, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 150, 0);
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(1131, 52);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddNewItemTool
            // 
            AddNewItemTool.Image = Properties.Resources.Add;
            AddNewItemTool.ImageTransparentColor = Color.Magenta;
            AddNewItemTool.Name = "AddNewItemTool";
            AddNewItemTool.Size = new Size(114, 49);
            AddNewItemTool.Text = "إضافة صنف جديد";
            AddNewItemTool.ToolTipText = "إضافة صنف جديد";
            AddNewItemTool.Click += AddNewItemTool_Click;
            // 
            // ItemExtraDataTool
            // 
            ItemExtraDataTool.DropDownItems.AddRange(new ToolStripItem[] { CurrentItemExpiryTool, CurrentItemPhoto });
            ItemExtraDataTool.Image = Properties.Resources.ExtraData;
            ItemExtraDataTool.ImageTransparentColor = Color.Magenta;
            ItemExtraDataTool.Name = "ItemExtraDataTool";
            ItemExtraDataTool.Size = new Size(192, 49);
            ItemExtraDataTool.Text = "بيانات إضافية عن الصنف الحالي";
            // 
            // CurrentItemExpiryTool
            // 
            CurrentItemExpiryTool.Name = "CurrentItemExpiryTool";
            CurrentItemExpiryTool.Size = new Size(209, 22);
            CurrentItemExpiryTool.Text = "تاريخ صلاحية الصنف الحالي";
            CurrentItemExpiryTool.Click += CurrentItemExpiryTool_Click;
            // 
            // CurrentItemPhoto
            // 
            CurrentItemPhoto.Image = Properties.Resources.Image;
            CurrentItemPhoto.Name = "CurrentItemPhoto";
            CurrentItemPhoto.Size = new Size(209, 22);
            CurrentItemPhoto.Text = "عرض صورة الصنف الحالي";
            CurrentItemPhoto.Click += CurrentItemPhoto_Click;
            // 
            // UpdateCurrentItemTool
            // 
            UpdateCurrentItemTool.Image = Properties.Resources.Edit;
            UpdateCurrentItemTool.ImageTransparentColor = Color.Magenta;
            UpdateCurrentItemTool.Name = "UpdateCurrentItemTool";
            UpdateCurrentItemTool.Size = new Size(160, 49);
            UpdateCurrentItemTool.Text = "تعديل بيانات الصنف الحالي";
            UpdateCurrentItemTool.Click += UpdateCurrentItemTool_Click;
            // 
            // DeleteCurrentItemTool
            // 
            DeleteCurrentItemTool.Image = Properties.Resources.Delete;
            DeleteCurrentItemTool.ImageTransparentColor = Color.Magenta;
            DeleteCurrentItemTool.Name = "DeleteCurrentItemTool";
            DeleteCurrentItemTool.Size = new Size(156, 49);
            DeleteCurrentItemTool.Text = "حذف بيانات الصنف الحالي";
            DeleteCurrentItemTool.Click += DeleteCurrentItemTool_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.Print;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(162, 49);
            toolStripButton1.Text = "طباعة تقرير بقائمة الأصناف";
            // 
            // ItemSearch
            // 
            ItemSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemSearch.Controls.Add(ItemSearchTextBox);
            ItemSearch.Controls.Add(ItemIdentifierLabel);
            ItemSearch.Location = new Point(12, 63);
            ItemSearch.Name = "ItemSearch";
            ItemSearch.RightToLeft = RightToLeft.Yes;
            ItemSearch.Size = new Size(1103, 91);
            ItemSearch.TabIndex = 5;
            ItemSearch.TabStop = false;
            ItemSearch.Text = "البحث عن صنف";
            // 
            // ItemSearchTextBox
            // 
            ItemSearchTextBox.Anchor = AnchorStyles.None;
            ItemSearchTextBox.Location = new Point(6, 34);
            ItemSearchTextBox.Name = "ItemSearchTextBox";
            ItemSearchTextBox.PlaceholderText = "برجاء إدخال إسم أو كود الصنف";
            ItemSearchTextBox.Size = new Size(1014, 23);
            ItemSearchTextBox.TabIndex = 1;
            ItemSearchTextBox.TextAlign = HorizontalAlignment.Center;
            ItemSearchTextBox.TextChanged += ItemSearchTextBox_TextChanged;
            // 
            // ItemIdentifierLabel
            // 
            ItemIdentifierLabel.Anchor = AnchorStyles.None;
            ItemIdentifierLabel.AutoSize = true;
            ItemIdentifierLabel.Location = new Point(1026, 37);
            ItemIdentifierLabel.Name = "ItemIdentifierLabel";
            ItemIdentifierLabel.Size = new Size(71, 15);
            ItemIdentifierLabel.TabIndex = 0;
            ItemIdentifierLabel.Text = "بيانات البحث:";
            // 
            // ItemsControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 639);
            Controls.Add(ItemsList);
            Controls.Add(toolStrip1);
            Controls.Add(ItemSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ItemsControlView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "عرض كل الأصناف";
            Activated += ItemsControlView_Activated;
            Load += ItemsControlView_Load;
            ItemsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ItemsListGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ItemSearch.ResumeLayout(false);
            ItemSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsList;
        public DataGridView ItemsListGridView;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn BarcodeColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn RetailPriceColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn CatalogRelatedColumn;
        private DataGridViewTextBoxColumn SectionRelatedColumn;
        private DataGridViewTextBoxColumn BrandRelatedColumn;
        private ToolStrip toolStrip1;
        private ToolStripButton AddNewItemTool;
        private ToolStripButton UpdateCurrentItemTool;
        private ToolStripButton DeleteCurrentItemTool;
        private GroupBox ItemSearch;
        private TextBox ItemSearchTextBox;
        private Label ItemIdentifierLabel;
        private ToolStripButton toolStripButton1;
        private ToolStripDropDownButton ItemExtraDataTool;
        private ToolStripMenuItem CurrentItemExpiryTool;
        private ToolStripMenuItem CurrentItemPhoto;
    }
}