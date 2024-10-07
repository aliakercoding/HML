using HMLalpha.Controllers;
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
    public partial class AddNewItemView : Form
    {
        public AddNewItemView()
        {
            InitializeComponent();
            DataTable catalogDataTable = ItemsController.PROCEDURE_ITEMRELATEDCATALOGS();
            ItemCatalogSelector.DataSource = catalogDataTable;
            ItemCatalogSelector.DisplayMember = "CATALOG_NAME";
            ItemCatalogSelector.ValueMember = "CATALOG_ID";

            DataTable sectionDataTable = ItemsController.PROCEDURE_ITEMRELATEDSECTIONS();
            ItemSectionSelector.DataSource = sectionDataTable;
            ItemSectionSelector.DisplayMember = "SECTION_NAME";
            ItemSectionSelector.ValueMember = "SECTION_ID";

            DataTable branddataTable = ItemsController.PROCEDURE_ITEMRELATEDBRANDS();
            ItemBrandSelector.DataSource = branddataTable;
            ItemBrandSelector.DisplayMember = "BRAND_NAME";
            ItemBrandSelector.ValueMember = "BRAND_ID";
        }


        private void AddNewItemView_Load(object sender, EventArgs e)
        {

        }

        private void ItemPhotoSelectorButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Joint Photographic Experts Group (JPEG)|*.jpg,*.jpeg,*.jpe,*.jfif|Portable Network Graphics (PNG)|*.png";
            openFileDialog.ShowDialog();
            ItemPhotoSelector.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
