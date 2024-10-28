namespace HMLalpha.Views
{
    partial class MainView
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
            MainViewMenuStrip = new MenuStrip();
            UserMenu = new ToolStripMenuItem();
            LoginMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            UserProfileMenu = new ToolStripMenuItem();
            ItemsMenu = new ToolStripMenuItem();
            ListItemsMenu = new ToolStripMenuItem();
            DefineNewItemMenu = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ItemStickersMenu = new ToolStripMenuItem();
            PurchaseInvoicesMenu = new ToolStripMenuItem();
            NewPurchaseInvoiceMenu = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ReturnPurchaseInvoiceMenu = new ToolStripMenuItem();
            SalesInvoicesMenu = new ToolStripMenuItem();
            NewSalesInvoiceMenu = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            ReturnSalesInvoiceMenu = new ToolStripMenuItem();
            TransfersMenu = new ToolStripMenuItem();
            IncomingTransfersMenu = new ToolStripMenuItem();
            OutgoingTransfersMenu = new ToolStripMenuItem();
            ReportsMenu = new ToolStripMenuItem();
            TotalPurchasesReport = new ToolStripMenuItem();
            TotalSalesReport = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            TotalItemsReport = new ToolStripMenuItem();
            ItemsExpiryReport = new ToolStripMenuItem();
            ItemsInOutReport = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            IncomingTransfersReport = new ToolStripMenuItem();
            OutgoingTransfersReport = new ToolStripMenuItem();
            AdminMenu = new ToolStripMenuItem();
            OffersMenu = new ToolStripMenuItem();
            PurchasesControlMenu = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            ItemsStockMenu = new ToolStripMenuItem();
            ItemShortageMenu = new ToolStripMenuItem();
            ExtraMenu = new ToolStripMenuItem();
            BrandsMenu = new ToolStripMenuItem();
            CustomersControlMenu = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            DatabaseMenu = new ToolStripMenuItem();
            DatabaseRefreshMenu = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            DatabaseBackupMenu = new ToolStripMenuItem();
            HelpMenu = new ToolStripMenuItem();
            SettingsMenu = new ToolStripMenuItem();
            HelperBookMenu = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            AboutMenu = new ToolStripMenuItem();
            UpdateCheckMenu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            MainViewMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainViewMenuStrip
            // 
            MainViewMenuStrip.Items.AddRange(new ToolStripItem[] { UserMenu, ItemsMenu, PurchaseInvoicesMenu, SalesInvoicesMenu, TransfersMenu, ReportsMenu, AdminMenu, ExtraMenu, HelpMenu });
            MainViewMenuStrip.Location = new Point(0, 0);
            MainViewMenuStrip.Name = "MainViewMenuStrip";
            MainViewMenuStrip.RightToLeft = RightToLeft.Yes;
            MainViewMenuStrip.Size = new Size(991, 24);
            MainViewMenuStrip.TabIndex = 1;
            MainViewMenuStrip.Text = "menuStrip1";
            // 
            // UserMenu
            // 
            UserMenu.DropDownItems.AddRange(new ToolStripItem[] { LoginMenu, toolStripSeparator1, UserProfileMenu });
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(67, 20);
            UserMenu.Text = "الم&ستخدم";
            // 
            // LoginMenu
            // 
            LoginMenu.Image = Properties.Resources.LoginUser;
            LoginMenu.Name = "LoginMenu";
            LoginMenu.Size = new Size(150, 22);
            LoginMenu.Text = "تسجيل ال&دخول";
            LoginMenu.Click += LoginMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            toolStripSeparator1.Visible = false;
            // 
            // UserProfileMenu
            // 
            UserProfileMenu.Image = Properties.Resources.UserProfile;
            UserProfileMenu.Name = "UserProfileMenu";
            UserProfileMenu.Size = new Size(150, 22);
            UserProfileMenu.Text = "ال&ملف الشخصي";
            UserProfileMenu.Visible = false;
            // 
            // ItemsMenu
            // 
            ItemsMenu.DropDownItems.AddRange(new ToolStripItem[] { ListItemsMenu, DefineNewItemMenu, toolStripSeparator2, ItemStickersMenu });
            ItemsMenu.Enabled = false;
            ItemsMenu.Name = "ItemsMenu";
            ItemsMenu.Size = new Size(60, 20);
            ItemsMenu.Text = "الأ&صناف";
            // 
            // ListItemsMenu
            // 
            ListItemsMenu.Image = Properties.Resources.ListItems;
            ListItemsMenu.Name = "ListItemsMenu";
            ListItemsMenu.ShortcutKeys = Keys.Control | Keys.L;
            ListItemsMenu.Size = new Size(207, 22);
            ListItemsMenu.Text = "&عرض كل الأصناف";
            ListItemsMenu.Click += ListItemsMenu_Click;
            // 
            // DefineNewItemMenu
            // 
            DefineNewItemMenu.Name = "DefineNewItemMenu";
            DefineNewItemMenu.ShortcutKeys = Keys.Control | Keys.N;
            DefineNewItemMenu.Size = new Size(207, 22);
            DefineNewItemMenu.Text = "&تعريف صنف جديد";
            DefineNewItemMenu.Click += DefineNewItemMenu_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(204, 6);
            // 
            // ItemStickersMenu
            // 
            ItemStickersMenu.Image = Properties.Resources.StickerPrint;
            ItemStickersMenu.Name = "ItemStickersMenu";
            ItemStickersMenu.Size = new Size(207, 22);
            ItemStickersMenu.Text = "&طباعة ملصقات أصناف";
            // 
            // PurchaseInvoicesMenu
            // 
            PurchaseInvoicesMenu.DropDownItems.AddRange(new ToolStripItem[] { NewPurchaseInvoiceMenu, toolStripSeparator3, ReturnPurchaseInvoiceMenu });
            PurchaseInvoicesMenu.Enabled = false;
            PurchaseInvoicesMenu.Name = "PurchaseInvoicesMenu";
            PurchaseInvoicesMenu.Size = new Size(102, 20);
            PurchaseInvoicesMenu.Text = "فواتير الم&شتريات";
            // 
            // NewPurchaseInvoiceMenu
            // 
            NewPurchaseInvoiceMenu.Image = Properties.Resources.NewInvoice;
            NewPurchaseInvoiceMenu.Name = "NewPurchaseInvoiceMenu";
            NewPurchaseInvoiceMenu.ShortcutKeys = Keys.Control | Keys.P;
            NewPurchaseInvoiceMenu.Size = new Size(224, 22);
            NewPurchaseInvoiceMenu.Text = "&فاتورة مشتريات جديدة";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // ReturnPurchaseInvoiceMenu
            // 
            ReturnPurchaseInvoiceMenu.Image = Properties.Resources.ReturnInvoice;
            ReturnPurchaseInvoiceMenu.Name = "ReturnPurchaseInvoiceMenu";
            ReturnPurchaseInvoiceMenu.Size = new Size(224, 22);
            ReturnPurchaseInvoiceMenu.Text = "&مرتجع لفاتورة مشتريات سابقة";
            // 
            // SalesInvoicesMenu
            // 
            SalesInvoicesMenu.DropDownItems.AddRange(new ToolStripItem[] { NewSalesInvoiceMenu, toolStripSeparator4, ReturnSalesInvoiceMenu });
            SalesInvoicesMenu.Enabled = false;
            SalesInvoicesMenu.Name = "SalesInvoicesMenu";
            SalesInvoicesMenu.Size = new Size(93, 20);
            SalesInvoicesMenu.Text = "فواتير ال&مبيعات";
            // 
            // NewSalesInvoiceMenu
            // 
            NewSalesInvoiceMenu.Image = Properties.Resources.NewInvoice;
            NewSalesInvoiceMenu.Name = "NewSalesInvoiceMenu";
            NewSalesInvoiceMenu.ShortcutKeys = Keys.Control | Keys.S;
            NewSalesInvoiceMenu.Size = new Size(214, 22);
            NewSalesInvoiceMenu.Text = "فاتورة مبيعات جديدة&";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(211, 6);
            // 
            // ReturnSalesInvoiceMenu
            // 
            ReturnSalesInvoiceMenu.Image = Properties.Resources.ReturnInvoice;
            ReturnSalesInvoiceMenu.Name = "ReturnSalesInvoiceMenu";
            ReturnSalesInvoiceMenu.Size = new Size(214, 22);
            ReturnSalesInvoiceMenu.Text = "&مرتجع لفاتورة مبيعات سابقة";
            // 
            // TransfersMenu
            // 
            TransfersMenu.DropDownItems.AddRange(new ToolStripItem[] { IncomingTransfersMenu, OutgoingTransfersMenu });
            TransfersMenu.Enabled = false;
            TransfersMenu.Name = "TransfersMenu";
            TransfersMenu.Size = new Size(66, 20);
            TransfersMenu.Text = "ال&تحويلات";
            // 
            // IncomingTransfersMenu
            // 
            IncomingTransfersMenu.Image = Properties.Resources.TransferFrom;
            IncomingTransfersMenu.Name = "IncomingTransfersMenu";
            IncomingTransfersMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            IncomingTransfersMenu.Size = new Size(250, 22);
            IncomingTransfersMenu.Text = "إستلام تحويل &من جهة";
            // 
            // OutgoingTransfersMenu
            // 
            OutgoingTransfersMenu.Image = Properties.Resources.TransferTo;
            OutgoingTransfersMenu.Name = "OutgoingTransfersMenu";
            OutgoingTransfersMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            OutgoingTransfersMenu.Size = new Size(250, 22);
            OutgoingTransfersMenu.Text = "إرسال تحويل &إلي جهة";
            // 
            // ReportsMenu
            // 
            ReportsMenu.DropDownItems.AddRange(new ToolStripItem[] { TotalPurchasesReport, TotalSalesReport, toolStripSeparator5, TotalItemsReport, ItemsExpiryReport, ItemsInOutReport, toolStripSeparator6, IncomingTransfersReport, OutgoingTransfersReport });
            ReportsMenu.Enabled = false;
            ReportsMenu.Name = "ReportsMenu";
            ReportsMenu.Size = new Size(54, 20);
            ReportsMenu.Text = "الت&قارير";
            // 
            // TotalPurchasesReport
            // 
            TotalPurchasesReport.Name = "TotalPurchasesReport";
            TotalPurchasesReport.Size = new Size(209, 22);
            TotalPurchasesReport.Text = "تقرير إجمالي م&شتريات";
            // 
            // TotalSalesReport
            // 
            TotalSalesReport.Name = "TotalSalesReport";
            TotalSalesReport.Size = new Size(209, 22);
            TotalSalesReport.Text = "تقرير إجمالي &مبيعات";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(206, 6);
            // 
            // TotalItemsReport
            // 
            TotalItemsReport.Name = "TotalItemsReport";
            TotalItemsReport.Size = new Size(209, 22);
            TotalItemsReport.Text = "تقرير إجمالي أ&صناف";
            // 
            // ItemsExpiryReport
            // 
            ItemsExpiryReport.Name = "ItemsExpiryReport";
            ItemsExpiryReport.Size = new Size(209, 22);
            ItemsExpiryReport.Text = "تقرير &تاريخ صلاحية الأصناف";
            // 
            // ItemsInOutReport
            // 
            ItemsInOutReport.Name = "ItemsInOutReport";
            ItemsInOutReport.Size = new Size(209, 22);
            ItemsInOutReport.Text = "تقرير &حركة الأصناف";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(206, 6);
            // 
            // IncomingTransfersReport
            // 
            IncomingTransfersReport.Name = "IncomingTransfersReport";
            IncomingTransfersReport.Size = new Size(209, 22);
            IncomingTransfersReport.Text = "تقرير التحويلات الم&ستلمة";
            // 
            // OutgoingTransfersReport
            // 
            OutgoingTransfersReport.Name = "OutgoingTransfersReport";
            OutgoingTransfersReport.Size = new Size(209, 22);
            OutgoingTransfersReport.Text = "تقرير التحويلات الم&رسلة";
            // 
            // AdminMenu
            // 
            AdminMenu.DropDownItems.AddRange(new ToolStripItem[] { OffersMenu, PurchasesControlMenu, toolStripSeparator7, ItemsStockMenu, ItemShortageMenu });
            AdminMenu.Enabled = false;
            AdminMenu.Name = "AdminMenu";
            AdminMenu.Size = new Size(79, 20);
            AdminMenu.Text = "بيانات إ&دارية";
            // 
            // OffersMenu
            // 
            OffersMenu.Image = Properties.Resources.Offers;
            OffersMenu.Name = "OffersMenu";
            OffersMenu.ShortcutKeys = Keys.Control | Keys.O;
            OffersMenu.Size = new Size(215, 22);
            OffersMenu.Text = "إدارة ال&عروض";
            // 
            // PurchasesControlMenu
            // 
            PurchasesControlMenu.Image = Properties.Resources.PurchaseControl;
            PurchasesControlMenu.Name = "PurchasesControlMenu";
            PurchasesControlMenu.Size = new Size(215, 22);
            PurchasesControlMenu.Text = "إدارة الم&شتريات";
            PurchasesControlMenu.Click += PurchasesControlMenu_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(212, 6);
            // 
            // ItemsStockMenu
            // 
            ItemsStockMenu.Image = Properties.Resources.CheckItems;
            ItemsStockMenu.Name = "ItemsStockMenu";
            ItemsStockMenu.Size = new Size(215, 22);
            ItemsStockMenu.Text = "التحقق من &توافر الأصناف";
            // 
            // ItemShortageMenu
            // 
            ItemShortageMenu.Image = Properties.Resources.ShortageRequest;
            ItemShortageMenu.Name = "ItemShortageMenu";
            ItemShortageMenu.Size = new Size(215, 22);
            ItemShortageMenu.Text = "إنشاء طلب بنوا&قص الصيدلية";
            // 
            // ExtraMenu
            // 
            ExtraMenu.DropDownItems.AddRange(new ToolStripItem[] { BrandsMenu, CustomersControlMenu, toolStripSeparator8, DatabaseMenu });
            ExtraMenu.Enabled = false;
            ExtraMenu.Name = "ExtraMenu";
            ExtraMenu.Size = new Size(85, 20);
            ExtraMenu.Text = "بيانات إ&ضافية";
            // 
            // BrandsMenu
            // 
            BrandsMenu.Name = "BrandsMenu";
            BrandsMenu.Size = new Size(181, 22);
            BrandsMenu.Text = "إدارة العلامات ال&تجارية";
            BrandsMenu.Click += BrandsMenu_Click;
            // 
            // CustomersControlMenu
            // 
            CustomersControlMenu.Image = Properties.Resources.CustomersControl;
            CustomersControlMenu.Name = "CustomersControlMenu";
            CustomersControlMenu.Size = new Size(181, 22);
            CustomersControlMenu.Text = "إدارة &عملاء الصيدلية";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(178, 6);
            // 
            // DatabaseMenu
            // 
            DatabaseMenu.DropDownItems.AddRange(new ToolStripItem[] { DatabaseRefreshMenu, toolStripSeparator9, DatabaseBackupMenu });
            DatabaseMenu.Image = Properties.Resources.DatabaseSettings;
            DatabaseMenu.Name = "DatabaseMenu";
            DatabaseMenu.Size = new Size(181, 22);
            DatabaseMenu.Text = "إدارة &قاعدة البيانات";
            // 
            // DatabaseRefreshMenu
            // 
            DatabaseRefreshMenu.Image = Properties.Resources.UpdateDatabase;
            DatabaseRefreshMenu.Name = "DatabaseRefreshMenu";
            DatabaseRefreshMenu.ShortcutKeys = Keys.F5;
            DatabaseRefreshMenu.Size = new Size(252, 22);
            DatabaseRefreshMenu.Text = "إجراء &تحديث يدوي لقاعدة البيانات";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(249, 6);
            // 
            // DatabaseBackupMenu
            // 
            DatabaseBackupMenu.Image = Properties.Resources.DatabaseBackup;
            DatabaseBackupMenu.Name = "DatabaseBackupMenu";
            DatabaseBackupMenu.ShortcutKeys = Keys.F8;
            DatabaseBackupMenu.Size = new Size(252, 22);
            DatabaseBackupMenu.Text = "إنشاء &نسخة إحتياطية";
            // 
            // HelpMenu
            // 
            HelpMenu.DropDownItems.AddRange(new ToolStripItem[] { SettingsMenu, HelperBookMenu, toolStripSeparator10, AboutMenu, UpdateCheckMenu });
            HelpMenu.Name = "HelpMenu";
            HelpMenu.Size = new Size(58, 20);
            HelpMenu.Text = "مسا&عدة";
            // 
            // SettingsMenu
            // 
            SettingsMenu.Image = Properties.Resources.Settings;
            SettingsMenu.Name = "SettingsMenu";
            SettingsMenu.Size = new Size(152, 22);
            SettingsMenu.Text = "إع&دادات البرنامج";
            // 
            // HelperBookMenu
            // 
            HelperBookMenu.Image = Properties.Resources.HelpTableOfContents;
            HelperBookMenu.Name = "HelperBookMenu";
            HelperBookMenu.Size = new Size(152, 22);
            HelperBookMenu.Text = "&كتيب الشرح";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(149, 6);
            // 
            // AboutMenu
            // 
            AboutMenu.Image = Properties.Resources.About;
            AboutMenu.Name = "AboutMenu";
            AboutMenu.ShortcutKeys = Keys.F1;
            AboutMenu.Size = new Size(152, 22);
            AboutMenu.Text = "&عن البرنامج";
            // 
            // UpdateCheckMenu
            // 
            UpdateCheckMenu.Name = "UpdateCheckMenu";
            UpdateCheckMenu.Size = new Size(152, 22);
            UpdateCheckMenu.Text = "البحث عن &ترقية";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(991, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(statusStrip1);
            Controls.Add(MainViewMenuStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = MainViewMenuStrip;
            Name = "MainView";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HML SYSTEM - Ali Aker for Coding";
            WindowState = FormWindowState.Maximized;
            Activated += MainView_Activated;
            Load += MainView_Load;
            MainViewMenuStrip.ResumeLayout(false);
            MainViewMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainViewMenuStrip;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem UserMenu;
        private ToolStripMenuItem ItemsMenu;
        private ToolStripMenuItem PurchaseInvoicesMenu;
        private ToolStripMenuItem LoginMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem UserProfileMenu;
        private ToolStripMenuItem ListItemsMenu;
        private ToolStripMenuItem DefineNewItemMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ItemStickersMenu;
        private ToolStripMenuItem NewPurchaseInvoiceMenu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ReturnPurchaseInvoiceMenu;
        private ToolStripMenuItem SalesInvoicesMenu;
        private ToolStripMenuItem NewSalesInvoiceMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem ReturnSalesInvoiceMenu;
        private ToolStripMenuItem TransfersMenu;
        private ToolStripMenuItem ReportsMenu;
        private ToolStripMenuItem AdminMenu;
        private ToolStripMenuItem ExtraMenu;
        private ToolStripMenuItem HelpMenu;
        private ToolStripMenuItem IncomingTransfersMenu;
        private ToolStripMenuItem OutgoingTransfersMenu;
        private ToolStripMenuItem TotalPurchasesReport;
        private ToolStripMenuItem TotalSalesReport;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem TotalItemsReport;
        private ToolStripMenuItem ItemsExpiryReport;
        private ToolStripMenuItem ItemsInOutReport;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem IncomingTransfersReport;
        private ToolStripMenuItem OutgoingTransfersReport;
        private ToolStripMenuItem OffersMenu;
        private ToolStripMenuItem PurchasesControlMenu;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem ItemsStockMenu;
        private ToolStripMenuItem ItemShortageMenu;
        private ToolStripMenuItem BrandsMenu;
        private ToolStripMenuItem CustomersControlMenu;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem DatabaseMenu;
        private ToolStripMenuItem DatabaseRefreshMenu;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem DatabaseBackupMenu;
        private ToolStripMenuItem SettingsMenu;
        private ToolStripMenuItem HelperBookMenu;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem AboutMenu;
        private ToolStripMenuItem UpdateCheckMenu;
    }
}