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
    public partial class ItemsControlView : Form
    {
        public ItemsControlView()
        {
            InitializeComponent();
        }
        public static long ID;
        private void ItemsControlView_Load(object sender, EventArgs e)
        {
            DataTable dataTable = ItemsController.PROCEDURE_DISPLAYALLITEMS();
            ItemsListGridView.Rows.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ItemsListGridView.Rows.Add(dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[7], dataRow[4], dataRow[5], dataRow[6]);

            }
        }

        private void ItemsControlView_Activated(object sender, EventArgs e)
        {
            ItemsControlView_Load(null, null);
        }

        private void ItemSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = ItemsController.PROCEDURE_SEARCHITEMS(ItemSearchTextBox.Text);
            ItemsListGridView.Rows.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ItemsListGridView.Rows.Add(dataRow[1], dataRow[2], dataRow[3], dataRow[7], dataRow[4], dataRow[5], dataRow[6]);

            }
        }

        private void CurrentItemPhoto_Click(object sender, EventArgs e)
        {
            if (ItemsListGridView.Rows.Count != 0)
            {
                ID = long.Parse(ItemsListGridView.SelectedRows[0].Cells[0].Value.ToString());
                byte[] array = ItemsController.PROCEDURE_DISPLAYITEMPHOTO(ID);
                MemoryStream memoryStream = new MemoryStream(array);
                ItemPhotoView itemPhotoView = new ItemPhotoView();
                itemPhotoView.ItemPhoto.Image = Image.FromStream(memoryStream);
                itemPhotoView.ShowDialog();

            }
            else
            {
                CurrentItemPhoto.Enabled = false;
            }
        }

        private void CurrentItemExpiryTool_Click(object sender, EventArgs e)
        {
            if (ItemsListGridView.Rows.Count != 0)
            {
                ID = long.Parse(ItemsListGridView.SelectedRows[0].Cells[0].Value.ToString());
                DataTable dataTable = ItemsController.PROCEDURE_DISPLAYITEMEXPIRY(ID);
                if (dataTable.Rows.Count > 0)
                {
                    ItemExpiryView itemExpiryView = new ItemExpiryView();
                    itemExpiryView.ItemExpiryGridView.DataSource = dataTable;
                    itemExpiryView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("عذرا لا توجد فواتير مشتريات للصنف الحالي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CurrentItemExpiryTool.Enabled = false;
            }
        }

        private void AddNewItemTool_Click(object sender, EventArgs e)
        {
            AddNewItemView addNewItemView = new AddNewItemView();
            addNewItemView.ShowDialog();
        }

        private void DeleteCurrentItemTool_Click(object sender, EventArgs e)
        {
            if (ItemsListGridView.Rows.Count != 0)
            {
                ID = long.Parse(ItemsListGridView.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من حذف الصنف الحالي؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dialogResult == DialogResult.Yes)
                {
                    ItemsController.PROCEDURE_DELETEITEM(ID);
                    MessageBox.Show("تم حذف الصنف بنجاح", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DeleteCurrentItemTool.Enabled = false;
            }
        }

        private void UpdateCurrentItemTool_Click(object sender, EventArgs e)
        {
            ID = long.Parse(ItemsListGridView.SelectedRows[0].Cells[0].Value.ToString());
            EditItemView editItemView = new EditItemView();
            editItemView.ShowDialog();
        }
    }
}
