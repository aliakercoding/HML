using HMLalpha.Controllers;
using System.Data;

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

        private void ItemBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemBarcodeTextBox.Text != String.Empty && ItemNameTextBox.Text != String.Empty && ItemRetailPriceTextBox.Text != String.Empty && ItemVendorPriceTextBox.Text != String.Empty && ItemPPITextBox.Text != String.Empty && ItemNPPTextBox.Text != String.Empty)
            {
                AddNewItemButton.Enabled = true;
            }
            else
            {
                AddNewItemButton.Enabled = false;
            }
        }
        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            ItemPhotoSelector.Image.Save(stream, ItemPhotoSelector.Image.RawFormat);
            byte[] photoArray = stream.ToArray();

            int rowsCount = ItemsController.PROCEDURE_ADDNEWITEM(long.Parse(ItemBarcodeTextBox.Text), ItemNameTextBox.Text, decimal.Parse(ItemRetailPriceTextBox.Text), decimal.Parse(ItemVendorPriceTextBox.Text), photoArray, decimal.Parse(ItemVATTextBox.Text), decimal.Parse(ItemPPITextBox.Text), decimal.Parse(ItemNPPTextBox.Text), decimal.Parse(UserPointsTextBox.Text), decimal.Parse(CustomerPointsTextBox.Text), (long)ItemCatalogSelector.SelectedValue, (long)ItemSectionSelector.SelectedValue, (long)ItemBrandSelector.SelectedValue);
            MessageBox.Show(" تم إضافة الصنف " + ItemNameTextBox.Text + " بنجاح ", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
