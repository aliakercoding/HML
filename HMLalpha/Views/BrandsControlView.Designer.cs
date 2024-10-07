namespace HMLalpha.Views
{
    partial class BrandsControlView
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
            BrandsList = new GroupBox();
            BrandsListGridView = new DataGridView();
            toolStrip1 = new ToolStrip();
            AddNewBrandTool = new ToolStripButton();
            UpdateCurrentBrandTool = new ToolStripButton();
            DeleteCurrentBrandTool = new ToolStripButton();
            PrintAllBrandsTool = new ToolStripButton();
            BrandSearch = new GroupBox();
            BrandSearchTextBox = new TextBox();
            BrandIdentifierLabel = new Label();
            BrandsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrandsListGridView).BeginInit();
            toolStrip1.SuspendLayout();
            BrandSearch.SuspendLayout();
            SuspendLayout();
            // 
            // BrandsList
            // 
            BrandsList.Controls.Add(BrandsListGridView);
            BrandsList.Location = new Point(12, 152);
            BrandsList.Name = "BrandsList";
            BrandsList.RightToLeft = RightToLeft.Yes;
            BrandsList.Size = new Size(1103, 471);
            BrandsList.TabIndex = 0;
            BrandsList.TabStop = false;
            BrandsList.Text = "قائمة العلامات التجارية";
            // 
            // BrandsListGridView
            // 
            BrandsListGridView.AllowUserToAddRows = false;
            BrandsListGridView.AllowUserToDeleteRows = false;
            BrandsListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BrandsListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BrandsListGridView.Dock = DockStyle.Fill;
            BrandsListGridView.Location = new Point(3, 19);
            BrandsListGridView.MultiSelect = false;
            BrandsListGridView.Name = "BrandsListGridView";
            BrandsListGridView.ReadOnly = true;
            BrandsListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BrandsListGridView.Size = new Size(1097, 449);
            BrandsListGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddNewBrandTool, UpdateCurrentBrandTool, DeleteCurrentBrandTool, PrintAllBrandsTool });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 150, 0);
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(1127, 52);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddNewBrandTool
            // 
            AddNewBrandTool.Image = Properties.Resources.Add;
            AddNewBrandTool.ImageTransparentColor = Color.Magenta;
            AddNewBrandTool.Name = "AddNewBrandTool";
            AddNewBrandTool.Size = new Size(152, 49);
            AddNewBrandTool.Text = "إضافة علامة تجارية جديدة";
            AddNewBrandTool.Click += AddNewBrandTool_Click;
            // 
            // UpdateCurrentBrandTool
            // 
            UpdateCurrentBrandTool.Image = Properties.Resources.Edit;
            UpdateCurrentBrandTool.ImageTransparentColor = Color.Magenta;
            UpdateCurrentBrandTool.Name = "UpdateCurrentBrandTool";
            UpdateCurrentBrandTool.Size = new Size(199, 49);
            UpdateCurrentBrandTool.Text = "تعديل بيانات العلامة التجارية الحالية";
            UpdateCurrentBrandTool.Click += UpdateCurrentBrandTool_Click;
            // 
            // DeleteCurrentBrandTool
            // 
            DeleteCurrentBrandTool.Image = Properties.Resources.Delete;
            DeleteCurrentBrandTool.ImageTransparentColor = Color.Magenta;
            DeleteCurrentBrandTool.Name = "DeleteCurrentBrandTool";
            DeleteCurrentBrandTool.Size = new Size(195, 49);
            DeleteCurrentBrandTool.Text = "حذف بيانات العلامة التجارية الحالية";
            DeleteCurrentBrandTool.Click += DeleteCurrentBrandTool_Click;
            // 
            // PrintAllBrandsTool
            // 
            PrintAllBrandsTool.Image = Properties.Resources.Print;
            PrintAllBrandsTool.ImageTransparentColor = Color.Magenta;
            PrintAllBrandsTool.Name = "PrintAllBrandsTool";
            PrintAllBrandsTool.Size = new Size(203, 49);
            PrintAllBrandsTool.Text = "طباعة تقرير بقائمة العلامات التجارية";
            // 
            // BrandSearch
            // 
            BrandSearch.Controls.Add(BrandSearchTextBox);
            BrandSearch.Controls.Add(BrandIdentifierLabel);
            BrandSearch.Location = new Point(12, 55);
            BrandSearch.Name = "BrandSearch";
            BrandSearch.RightToLeft = RightToLeft.Yes;
            BrandSearch.Size = new Size(1103, 91);
            BrandSearch.TabIndex = 2;
            BrandSearch.TabStop = false;
            BrandSearch.Text = "البحث عن علامة تجارية";
            // 
            // BrandSearchTextBox
            // 
            BrandSearchTextBox.Location = new Point(6, 34);
            BrandSearchTextBox.Name = "BrandSearchTextBox";
            BrandSearchTextBox.PlaceholderText = "برجاء إدخال إسم أو كود العلامة التجارية";
            BrandSearchTextBox.Size = new Size(1014, 23);
            BrandSearchTextBox.TabIndex = 1;
            BrandSearchTextBox.TextAlign = HorizontalAlignment.Center;
            BrandSearchTextBox.TextChanged += BrandSearchTextBox_TextChanged;
            // 
            // BrandIdentifierLabel
            // 
            BrandIdentifierLabel.AutoSize = true;
            BrandIdentifierLabel.Location = new Point(1026, 37);
            BrandIdentifierLabel.Name = "BrandIdentifierLabel";
            BrandIdentifierLabel.Size = new Size(71, 15);
            BrandIdentifierLabel.TabIndex = 0;
            BrandIdentifierLabel.Text = "بيانات البحث:";
            // 
            // BrandsControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 635);
            Controls.Add(BrandSearch);
            Controls.Add(toolStrip1);
            Controls.Add(BrandsList);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "BrandsControlView";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة العلامات التجارية";
            Activated += BrandsControlView_Activated;
            Load += BrandsControlView_Load;
            BrandsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BrandsListGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            BrandSearch.ResumeLayout(false);
            BrandSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BrandsList;
        public DataGridView BrandsListGridView;
        private ToolStrip toolStrip1;
        private ToolStripButton AddNewBrandTool;
        private ToolStripButton UpdateCurrentBrandTool;
        private ToolStripButton DeleteCurrentBrandTool;
        private ToolStripButton PrintAllBrandsTool;
        private GroupBox BrandSearch;
        private TextBox BrandSearchTextBox;
        private Label BrandIdentifierLabel;
    }
}