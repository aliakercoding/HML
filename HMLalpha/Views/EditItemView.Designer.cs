namespace HMLalpha.Views
{
    partial class EditItemView
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
            components = new System.ComponentModel.Container();
            HelperTooltip = new ToolTip(components);
            ItemNPPTextBox = new TextBox();
            ItemPPITextBox = new TextBox();
            ItemPhotoSelectorButton = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label10 = new Label();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            label14 = new Label();
            splitContainer1 = new SplitContainer();
            ItemRelatedOffersButton = new Button();
            ItemPhotoSelector = new PictureBox();
            UserPointsTextBox = new TextBox();
            CustomerPointsTextBox = new TextBox();
            ItemBrandSelector = new ComboBox();
            ItemSectionSelector = new ComboBox();
            ItemCatalogSelector = new ComboBox();
            label13 = new Label();
            label15 = new Label();
            ItemVATTextBox = new TextBox();
            ItemVendorPriceTextBox = new TextBox();
            ItemRetailPriceTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemBarcodeTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CancelButton = new Button();
            UpdateItemButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPhotoSelector).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // HelperTooltip
            // 
            HelperTooltip.ShowAlways = true;
            HelperTooltip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ItemNPPTextBox
            // 
            ItemNPPTextBox.Location = new Point(41, 372);
            ItemNPPTextBox.Name = "ItemNPPTextBox";
            ItemNPPTextBox.PlaceholderText = "برجاء إدخال العدد المكون لكل جزء هنا مثال:(3)";
            ItemNPPTextBox.RightToLeft = RightToLeft.Yes;
            ItemNPPTextBox.Size = new Size(126, 23);
            ItemNPPTextBox.TabIndex = 23;
            HelperTooltip.SetToolTip(ItemNPPTextBox, "العدد لكل جزء يعني أن الجزء الواحد من الصنف (الشريط) يتكون من كم (قرص / كبسول) مثال: الشريط الواحد يتألف من 10 أقراص");
            ItemNPPTextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // ItemPPITextBox
            // 
            ItemPPITextBox.Location = new Point(317, 372);
            ItemPPITextBox.Name = "ItemPPITextBox";
            ItemPPITextBox.PlaceholderText = "برجاء إدخال عدد الأجزاء هنا مثال:(3)";
            ItemPPITextBox.RightToLeft = RightToLeft.Yes;
            ItemPPITextBox.Size = new Size(102, 23);
            ItemPPITextBox.TabIndex = 24;
            HelperTooltip.SetToolTip(ItemPPITextBox, "عدد الأجزاء في الصنف عبارة عن من كم جزء (شريط) تتكون العبوة الكاملة للصنف مثال: العبوة الواحدة = 3 أشرطة");
            ItemPPITextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // ItemPhotoSelectorButton
            // 
            ItemPhotoSelectorButton.Enabled = false;
            ItemPhotoSelectorButton.Image = Properties.Resources.Image;
            ItemPhotoSelectorButton.Location = new Point(241, 444);
            ItemPhotoSelectorButton.Name = "ItemPhotoSelectorButton";
            ItemPhotoSelectorButton.Size = new Size(36, 23);
            ItemPhotoSelectorButton.TabIndex = 3;
            ItemPhotoSelectorButton.Tag = "إختيار صورة للصنف";
            HelperTooltip.SetToolTip(ItemPhotoSelectorButton, "قم بالضغط هنا لإختيار صورة للصنف");
            ItemPhotoSelectorButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(433, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "إلغاء";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-121, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 39);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(534, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "إضافة";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 336);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(169, 15);
            label10.TabIndex = 0;
            label10.Text = "عدد النقاط المكتسبة (للمستخدم):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(413, 130);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(58, 15);
            label12.TabIndex = 0;
            label12.Text = "تابع لقسم:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 287);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(154, 15);
            label9.TabIndex = 0;
            label9.Text = "عدد النقاط المكتسبة (للعميل):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(405, 81);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(66, 15);
            label11.TabIndex = 0;
            label11.Text = "تابع لكتالوج:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(181, 33);
            label14.Name = "label14";
            label14.Size = new Size(118, 15);
            label14.TabIndex = 0;
            label14.Text = "بيانات الصنف الإضافية";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ItemPhotoSelectorButton);
            splitContainer1.Panel1.Controls.Add(ItemRelatedOffersButton);
            splitContainer1.Panel1.Controls.Add(ItemPhotoSelector);
            splitContainer1.Panel1.Controls.Add(UserPointsTextBox);
            splitContainer1.Panel1.Controls.Add(CustomerPointsTextBox);
            splitContainer1.Panel1.Controls.Add(ItemBrandSelector);
            splitContainer1.Panel1.Controls.Add(ItemSectionSelector);
            splitContainer1.Panel1.Controls.Add(ItemCatalogSelector);
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(label15);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label14);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ItemNPPTextBox);
            splitContainer1.Panel2.Controls.Add(ItemPPITextBox);
            splitContainer1.Panel2.Controls.Add(ItemVATTextBox);
            splitContainer1.Panel2.Controls.Add(ItemVendorPriceTextBox);
            splitContainer1.Panel2.Controls.Add(ItemRetailPriceTextBox);
            splitContainer1.Panel2.Controls.Add(ItemNameTextBox);
            splitContainer1.Panel2.Controls.Add(ItemBarcodeTextBox);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1046, 490);
            splitContainer1.SplitterDistance = 490;
            splitContainer1.TabIndex = 2;
            // 
            // ItemRelatedOffersButton
            // 
            ItemRelatedOffersButton.Enabled = false;
            ItemRelatedOffersButton.Location = new Point(12, 426);
            ItemRelatedOffersButton.Name = "ItemRelatedOffersButton";
            ItemRelatedOffersButton.Size = new Size(146, 23);
            ItemRelatedOffersButton.TabIndex = 3;
            ItemRelatedOffersButton.Text = "العروض المرتبطة بالصنف";
            ItemRelatedOffersButton.UseVisualStyleBackColor = true;
            // 
            // ItemPhotoSelector
            // 
            ItemPhotoSelector.Image = Properties.Resources.ItemDefaultPhoto;
            ItemPhotoSelector.Location = new Point(283, 397);
            ItemPhotoSelector.Name = "ItemPhotoSelector";
            ItemPhotoSelector.Size = new Size(106, 70);
            ItemPhotoSelector.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPhotoSelector.TabIndex = 2;
            ItemPhotoSelector.TabStop = false;
            // 
            // UserPointsTextBox
            // 
            UserPointsTextBox.Location = new Point(12, 333);
            UserPointsTextBox.Name = "UserPointsTextBox";
            UserPointsTextBox.PlaceholderText = "عدد النقاط المكتسبة لكل عملية شراء";
            UserPointsTextBox.RightToLeft = RightToLeft.Yes;
            UserPointsTextBox.Size = new Size(287, 23);
            UserPointsTextBox.TabIndex = 1;
            // 
            // CustomerPointsTextBox
            // 
            CustomerPointsTextBox.Location = new Point(12, 284);
            CustomerPointsTextBox.Name = "CustomerPointsTextBox";
            CustomerPointsTextBox.PlaceholderText = "عدد النقاط المكتسبة لكل عملية شراء";
            CustomerPointsTextBox.RightToLeft = RightToLeft.Yes;
            CustomerPointsTextBox.Size = new Size(299, 23);
            CustomerPointsTextBox.TabIndex = 1;
            // 
            // ItemBrandSelector
            // 
            ItemBrandSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemBrandSelector.FormattingEnabled = true;
            ItemBrandSelector.Location = new Point(12, 176);
            ItemBrandSelector.Name = "ItemBrandSelector";
            ItemBrandSelector.Size = new Size(347, 23);
            ItemBrandSelector.TabIndex = 1;
            // 
            // ItemSectionSelector
            // 
            ItemSectionSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemSectionSelector.FormattingEnabled = true;
            ItemSectionSelector.Location = new Point(12, 127);
            ItemSectionSelector.Name = "ItemSectionSelector";
            ItemSectionSelector.Size = new Size(387, 23);
            ItemSectionSelector.TabIndex = 1;
            // 
            // ItemCatalogSelector
            // 
            ItemCatalogSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCatalogSelector.FormattingEnabled = true;
            ItemCatalogSelector.Location = new Point(12, 78);
            ItemCatalogSelector.Name = "ItemCatalogSelector";
            ItemCatalogSelector.Size = new Size(387, 23);
            ItemCatalogSelector.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(365, 179);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(106, 15);
            label13.TabIndex = 0;
            label13.Text = "تابع للعلامة التجارية:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(395, 430);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(76, 15);
            label15.TabIndex = 0;
            label15.Text = "صورة الصنف:";
            // 
            // ItemVATTextBox
            // 
            ItemVATTextBox.Location = new Point(297, 293);
            ItemVATTextBox.Name = "ItemVATTextBox";
            ItemVATTextBox.PlaceholderText = "برجاء إدخال قيمة الضريبة هنا مثال:(0.75)";
            ItemVATTextBox.RightToLeft = RightToLeft.Yes;
            ItemVATTextBox.Size = new Size(121, 23);
            ItemVATTextBox.TabIndex = 25;
            ItemVATTextBox.Tag = "برجاء إدخال قيمة الضريبة هنا مثال:(0.75)";
            // 
            // ItemVendorPriceTextBox
            // 
            ItemVendorPriceTextBox.Location = new Point(41, 276);
            ItemVendorPriceTextBox.Name = "ItemVendorPriceTextBox";
            ItemVendorPriceTextBox.PlaceholderText = "برجاء إدخال السعر هنا مثال:(8.50)";
            ItemVendorPriceTextBox.RightToLeft = RightToLeft.Yes;
            ItemVendorPriceTextBox.Size = new Size(126, 23);
            ItemVendorPriceTextBox.TabIndex = 26;
            ItemVendorPriceTextBox.Tag = "برجاء إدخال السعر هنا مثال:(8.50)";
            ItemVendorPriceTextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // ItemRetailPriceTextBox
            // 
            ItemRetailPriceTextBox.Location = new Point(297, 255);
            ItemRetailPriceTextBox.Name = "ItemRetailPriceTextBox";
            ItemRetailPriceTextBox.PlaceholderText = "برجاء إدخال السعر هنا مثال:(8.50)";
            ItemRetailPriceTextBox.RightToLeft = RightToLeft.Yes;
            ItemRetailPriceTextBox.Size = new Size(151, 23);
            ItemRetailPriceTextBox.TabIndex = 27;
            ItemRetailPriceTextBox.Tag = "برجاء إدخال السعر هنا مثال:(8.50)";
            ItemRetailPriceTextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(41, 179);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.PlaceholderText = "برجاء إدخال الإسم هنا مثال:(بانادول)";
            ItemNameTextBox.RightToLeft = RightToLeft.Yes;
            ItemNameTextBox.Size = new Size(427, 23);
            ItemNameTextBox.TabIndex = 28;
            ItemNameTextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // ItemBarcodeTextBox
            // 
            ItemBarcodeTextBox.Location = new Point(41, 141);
            ItemBarcodeTextBox.Name = "ItemBarcodeTextBox";
            ItemBarcodeTextBox.PlaceholderText = "برجاء إدخال الباركود هنا مثال:(123456789)";
            ItemBarcodeTextBox.RightToLeft = RightToLeft.Yes;
            ItemBarcodeTextBox.Size = new Size(323, 23);
            ItemBarcodeTextBox.TabIndex = 29;
            ItemBarcodeTextBox.TextChanged += ItemBarcodeTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(191, 375);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(76, 15);
            label8.TabIndex = 16;
            label8.Text = "العدد لكل جزء:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 375);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(118, 15);
            label7.TabIndex = 17;
            label7.Text = "عدد الأجزاء في الصنف:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 296);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(118, 15);
            label6.TabIndex = 18;
            label6.Text = "ضريبة القيمة المضافة:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 279);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(94, 15);
            label5.TabIndex = 19;
            label5.Text = "سعر شراء الصنف:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 258);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(88, 15);
            label4.TabIndex = 20;
            label4.Text = "سعر بيع الصنف:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 182);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(68, 15);
            label3.TabIndex = 21;
            label3.Text = "إسم الصنف:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 144);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(169, 15);
            label2.TabIndex = 22;
            label2.Text = "المعرف الدولي للصنف (الباركود):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "بيانات الصنف الأساسية";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(433, 8);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "إلغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // UpdateItemButton
            // 
            UpdateItemButton.Location = new Point(534, 8);
            UpdateItemButton.Name = "UpdateItemButton";
            UpdateItemButton.Size = new Size(75, 23);
            UpdateItemButton.TabIndex = 2;
            UpdateItemButton.Text = "تعديل";
            UpdateItemButton.UseVisualStyleBackColor = true;
            UpdateItemButton.Click += UpdateItemButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(UpdateItemButton);
            panel2.Location = new Point(4, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 39);
            panel2.TabIndex = 4;
            // 
            // EditItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 540);
            Controls.Add(panel2);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "EditItemView";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تعديل بيانات الصنف";
            Load += EditItemView_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ItemPhotoSelector).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip HelperTooltip;
        private TextBox ItemNPPTextBox;
        private TextBox ItemPPITextBox;
        private Button ItemPhotoSelectorButton;
        private Button button2;
        private Panel panel1;
        private Button button1;
        private Label label10;
        private Label label12;
        private Label label9;
        private Label label11;
        private Label label14;
        private SplitContainer splitContainer1;
        private Button ItemRelatedOffersButton;
        private PictureBox ItemPhotoSelector;
        private TextBox UserPointsTextBox;
        private TextBox CustomerPointsTextBox;
        private ComboBox ItemBrandSelector;
        private ComboBox ItemSectionSelector;
        private ComboBox ItemCatalogSelector;
        private Label label13;
        private Label label15;
        private TextBox ItemVATTextBox;
        private TextBox ItemVendorPriceTextBox;
        private TextBox ItemRetailPriceTextBox;
        private TextBox ItemNameTextBox;
        private TextBox ItemBarcodeTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CancelButton;
        private Button UpdateItemButton;
        private Panel panel2;
    }
}