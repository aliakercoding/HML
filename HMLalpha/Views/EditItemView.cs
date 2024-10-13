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
    public partial class EditItemView : Form
    {
        public EditItemView()
        {
            InitializeComponent();
        }

        private void loadItemBasicData()
        {
            DataTable dataTable = ItemsController.PROCEDURE_SELECTITEM(ItemsControlView.ID);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ItemBarcodeTextBox.Text = dataRow["ITEM_BARCODE"].ToString();
                ItemNameTextBox.Text = dataRow["ITEM_NAME"].ToString();
                ItemRetailPriceTextBox.Text = dataRow["ITEM_RETAIL_PRICE"].ToString();
                ItemVendorPriceTextBox.Text = dataRow["ITEM_VENDOR_PRICE"].ToString();
                ItemVATTextBox.Text = dataRow["VAT_VALUE"].ToString();
                ItemPPITextBox.Text = dataRow["PARTS_PER_ITEM"].ToString();
                ItemNPPTextBox.Text = dataRow["NUMBER_PER_PART"].ToString();
                ItemCatalogSelector.DisplayMember = "CATALOG_NAME";
                ItemCatalogSelector.ValueMember = "CATALOG_ID";
                ItemCatalogSelector.Text = dataRow["CATALOG_NAME"].ToString();
                ItemSectionSelector.DisplayMember = "SECTION_NAME";
                ItemSectionSelector.ValueMember = "SECTION_ID";
                ItemSectionSelector.Text = dataRow["SECTION_NAME"].ToString();
                ItemBrandSelector.DisplayMember = "BRAND_NAME";
                ItemBrandSelector.ValueMember = "BRAND_ID";
                ItemBrandSelector.Text = dataRow["BRAND_NAME"].ToString();
                CustomerPointsTextBox.Text = dataRow["CUSTOMER_ACQUIRED_POINTS"].ToString();
                UserPointsTextBox.Text = dataRow["USER_ACQUIRED_POINTS"].ToString();
                byte[] array = (byte[])dataRow["ITEM_PHOTO"];
                MemoryStream memoryStream = new MemoryStream(array);
                ItemPhotoSelector.Image = Image.FromStream(memoryStream);
            }
        }

        private void loadItemRelatedData()
        {
            DataTable CatalogdataTable = ItemsController.PROCEDURE_ITEMRELATEDCATALOGS();
            ItemCatalogSelector.DataSource = CatalogdataTable;

            DataTable SectiondataTable = ItemsController.PROCEDURE_ITEMRELATEDSECTIONS();
            ItemSectionSelector.DataSource = SectiondataTable;

            DataTable BranddataTable = ItemsController.PROCEDURE_ITEMRELATEDBRANDS();
            ItemBrandSelector.DataSource = BranddataTable;
        }

        private void EditItemView_Load(object sender, EventArgs e)
        {
            loadItemRelatedData();
            loadItemBasicData();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            ItemPhotoSelector.Image.Save(stream, ItemPhotoSelector.Image.RawFormat);
            byte[] photoArray = stream.ToArray();

            int rowsCount = ItemsController.PROCEDURE_UPDATEITEM(ItemsControlView.ID, long.Parse(ItemBarcodeTextBox.Text), ItemNameTextBox.Text, decimal.Parse(ItemRetailPriceTextBox.Text), decimal.Parse(ItemVendorPriceTextBox.Text), photoArray, decimal.Parse(ItemVATTextBox.Text), decimal.Parse(ItemPPITextBox.Text), decimal.Parse(ItemNPPTextBox.Text), decimal.Parse(UserPointsTextBox.Text), decimal.Parse(CustomerPointsTextBox.Text), (long)ItemCatalogSelector.SelectedValue, (long)ItemSectionSelector.SelectedValue, (long)ItemBrandSelector.SelectedValue);
            MessageBox.Show(" تم تعديل بيانات الصنف " + ItemNameTextBox.Text + " بنجاح ", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemBarcodeTextBox.Text != String.Empty && ItemNameTextBox.Text != String.Empty && ItemRetailPriceTextBox.Text != String.Empty && ItemVendorPriceTextBox.Text != String.Empty && ItemPPITextBox.Text != String.Empty && ItemNPPTextBox.Text != String.Empty)
            {
                UpdateItemButton.Enabled = true;
            }
            else
            {
                UpdateItemButton.Enabled = false;
            }
        }
    }
}

