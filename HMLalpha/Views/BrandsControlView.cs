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
    public partial class BrandsControlView : Form
    {
        public BrandsControlView()
        {
            InitializeComponent();
        }


        public static int ID;


        private void BrandsControlView_Load(object? sender, EventArgs? e)
        {
            DataTable datatable =
            BrandsController.PROCEDURE_DISPLAYALLBRANDS();
            BrandsListGridView.DataSource = datatable;
            if (datatable.Rows.Count == 0)
            {
                UpdateCurrentBrandTool.Enabled = false;
            }
        }

        private void UpdateCurrentBrandTool_Click(object sender, EventArgs e)
        {
            ID = int.Parse(BrandsListGridView.SelectedRows[0].Cells[0].Value.ToString());
            EditBrandView editBrandView = new EditBrandView();
            editBrandView.ShowDialog();
        }

        private void AddNewBrandTool_Click(object sender, EventArgs e)
        {
            AddNewBrandView addNewBrandView = new AddNewBrandView();
            addNewBrandView.ShowDialog();
        }

        private void BrandSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = BrandsController.PROCEDURE_SEARCHBRANDS(BrandSearchTextBox.Text);
            BrandsListGridView.DataSource = dataTable;
        }

        private void BrandsControlView_Activated(object sender, EventArgs e)
        {
            BrandsControlView_Load(null, null);
        }

        private void DeleteCurrentBrandTool_Click(object sender, EventArgs e)
        {
            ID = int.Parse(BrandsListGridView.CurrentRow.Cells[0].Value.ToString());
            
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من حذف العلامة التجارية المحددة!", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                int rowsCount = BrandsController.PROCEDURE_DELETEBRAND(ID);
                MessageBox.Show("تم حذف العلامة التجارية بنجاح", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
