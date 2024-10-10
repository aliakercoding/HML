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
            toolStrip1 = new ToolStrip();
            AddNewItemTool = new ToolStripButton();
            UpdateCurrentItemTool = new ToolStripButton();
            DeleteCurrentItemTool = new ToolStripButton();
            PrintAllItemsTool = new ToolStripButton();
            ItemSearch = new GroupBox();
            ItemSearchTextBox = new TextBox();
            ItemIdentifierLabel = new Label();
            toolStripButton1 = new ToolStripButton();
            ItemExtraDataTool = new ToolStripDropDownButton();
            CurrentItemExpiryTool = new ToolStripMenuItem();
            CurrentItemPhoto = new ToolStripMenuItem();
            ItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsListGridView).BeginInit();
            toolStrip1.SuspendLayout();
            ItemSearch.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsList
            // 
            ItemsList.Controls.Add(ItemsListGridView);
            ItemsList.Location = new Point(12, 160);
            ItemsList.Name = "ItemsList";
            ItemsList.RightToLeft = RightToLeft.Yes;
            ItemsList.Size = new Size(1103, 471);
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
            ItemsListGridView.Dock = DockStyle.Fill;
            ItemsListGridView.Location = new Point(3, 19);
            ItemsListGridView.MultiSelect = false;
            ItemsListGridView.Name = "ItemsListGridView";
            ItemsListGridView.ReadOnly = true;
            ItemsListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsListGridView.Size = new Size(1097, 449);
            ItemsListGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddNewItemTool, ItemExtraDataTool, UpdateCurrentItemTool, DeleteCurrentItemTool, PrintAllItemsTool, toolStripButton1 });
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
            // 
            // UpdateCurrentItemTool
            // 
            UpdateCurrentItemTool.Image = Properties.Resources.Edit;
            UpdateCurrentItemTool.ImageTransparentColor = Color.Magenta;
            UpdateCurrentItemTool.Name = "UpdateCurrentItemTool";
            UpdateCurrentItemTool.Size = new Size(160, 49);
            UpdateCurrentItemTool.Text = "تعديل بيانات الصنف الحالي";
            // 
            // DeleteCurrentItemTool
            // 
            DeleteCurrentItemTool.Image = Properties.Resources.Delete;
            DeleteCurrentItemTool.ImageTransparentColor = Color.Magenta;
            DeleteCurrentItemTool.Name = "DeleteCurrentItemTool";
            DeleteCurrentItemTool.Size = new Size(156, 49);
            DeleteCurrentItemTool.Text = "حذف بيانات الصنف الحالي";
            // 
            // PrintAllItemsTool
            // 
            PrintAllItemsTool.Image = Properties.Resources.Print;
            PrintAllItemsTool.ImageTransparentColor = Color.Magenta;
            PrintAllItemsTool.Name = "PrintAllItemsTool";
            PrintAllItemsTool.Size = new Size(162, 49);
            PrintAllItemsTool.Text = "طباعة تقرير بقائمة الأصناف";
            // 
            // ItemSearch
            // 
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
            ItemSearchTextBox.Location = new Point(6, 34);
            ItemSearchTextBox.Name = "ItemSearchTextBox";
            ItemSearchTextBox.PlaceholderText = "برجاء إدخال إسم أو كود الصنف";
            ItemSearchTextBox.Size = new Size(1014, 23);
            ItemSearchTextBox.TabIndex = 1;
            ItemSearchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ItemIdentifierLabel
            // 
            ItemIdentifierLabel.AutoSize = true;
            ItemIdentifierLabel.Location = new Point(1026, 37);
            ItemIdentifierLabel.Name = "ItemIdentifierLabel";
            ItemIdentifierLabel.Size = new Size(71, 15);
            ItemIdentifierLabel.TabIndex = 0;
            ItemIdentifierLabel.Text = "بيانات البحث:";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.ExportData;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(131, 49);
            toolStripButton1.Text = "تصدير قائمة الأصناف";
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
            // 
            // CurrentItemPhoto
            // 
            CurrentItemPhoto.Image = Properties.Resources.Image;
            CurrentItemPhoto.Name = "CurrentItemPhoto";
            CurrentItemPhoto.Size = new Size(209, 22);
            CurrentItemPhoto.Text = "عرض صورة الصنف الحالي";
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
        private ToolStrip toolStrip1;
        private ToolStripButton AddNewItemTool;
        private ToolStripButton UpdateCurrentItemTool;
        private ToolStripButton DeleteCurrentItemTool;
        private ToolStripButton PrintAllItemsTool;
        private GroupBox ItemSearch;
        private TextBox ItemSearchTextBox;
        private Label ItemIdentifierLabel;
        private ToolStripButton toolStripButton1;
        private ToolStripDropDownButton ItemExtraDataTool;
        private ToolStripMenuItem CurrentItemExpiryTool;
        private ToolStripMenuItem CurrentItemPhoto;
    }
}