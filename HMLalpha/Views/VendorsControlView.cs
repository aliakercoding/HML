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
    public partial class VendorsControlView : Form
    {
        public VendorsControlView()
        {
            InitializeComponent();
        }
        public static int ID;
        private void VendorsControlView_Load(object sender, EventArgs e)
        {
            DataTable dataTable = VendorsController.PROCEDURE_DISPLAYALLVENDORS();
            VendorsListGridView.Rows.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                VendorsListGridView.Rows.Add(dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4]);
            }
        }

        private void VendorSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = VendorsController.PROCEDURE_SEARCHVENDORS(VendorSearchTextBox.Text);
            VendorsListGridView.DataSource = dataTable;
        }

        private void AddNewVendorTool_Click(object sender, EventArgs e)
        {
            AddNewVendorView addNewVendorView = new AddNewVendorView();
            addNewVendorView.ShowDialog();
        }

        private void VendorsControlView_Activated(object sender, EventArgs e)
        {
            VendorsControlView_Load(null, null);
        }

        private void UpdateCurrentVendorTool_Click(object sender, EventArgs e)
        {
            ID = int.Parse(VendorsListGridView.SelectedRows[0].Cells[0].Value.ToString());
            EditVendorView editVendorView = new EditVendorView();
            editVendorView.ShowDialog();
        }

        private void DeleteCurrentVendorTool_Click(object sender, EventArgs e)
        {
            ID = int.Parse(VendorsListGridView.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من حذف المورد الحالي!", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                int rowsCount = VendorsController.PROCEDURE_DELETEVENDOR(ID);
                MessageBox.Show("تم حذف المورد بنجاح", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
