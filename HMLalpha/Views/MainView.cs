using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMLalpha.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void المستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Check if user has been loged in or not
        public static bool loginCheck = false;
        private void LoginMenu_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
        }

        private void MainView_Activated(object sender, EventArgs e)
        {
            toolStripSeparator1.Visible = UserProfileMenu.Visible = loginCheck;
            ItemsMenu.Enabled = PurchaseInvoicesMenu.Enabled = SalesInvoicesMenu.Enabled = TransfersMenu.Enabled = ReportsMenu.Enabled = AdminMenu.Enabled = ExtraMenu.Enabled = loginCheck;
        }

        private void BrandsMenu_Click(object sender, EventArgs e)
        {
            BrandsControlView brandsControlView = new BrandsControlView();
            brandsControlView.ShowDialog();
        }

        private void DefineNewItemMenu_Click(object sender, EventArgs e)
        {
            AddNewItemView addNewItemView = new AddNewItemView();
            addNewItemView.ShowDialog();
        }

        private void ListItemsMenu_Click(object sender, EventArgs e)
        {
            ItemsControlView itemsControlView = new ItemsControlView();
            itemsControlView.ShowDialog();
        }

        private void PurchasesControlMenu_Click(object sender, EventArgs e)
        {
            VendorsControlView vendorsControlView = new VendorsControlView();
            vendorsControlView.ShowDialog();    
        }
    }
}
