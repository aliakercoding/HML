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
    public partial class EditVendorView : Form
    {
        public EditVendorView()
        {
            InitializeComponent();
        }

        private void EditVendorView_Load(object sender, EventArgs e)
        {
            DataTable dataTable = VendorsController.PROCEDURE_SELECTVENDOR(VendorsControlView.ID);
            foreach (DataRow row in dataTable.Rows)
            {
                VendorNameTextBox.Text = row["VENDOR_NAME"].ToString();
                VendorContactTextBox.Text = row["VENDOR_CONTACT"].ToString();
                VendorAddressTextArea.Text = row["VENDOR_ADDRESS"].ToString();
                VendorCreditTextBox.Text = row["VENDOR_TOTAL_CREDIT"].ToString();
            }
        }

        private void EditVendorButton_Click(object sender, EventArgs e)
        {

            int rowsCount = VendorsController.PROCEDURE_UPDATEVENDOR(VendorsControlView.ID, VendorNameTextBox.Text, VendorContactTextBox.Text, VendorAddressTextArea.Text);
            MessageBox.Show("تم تعديل بيانات المورد بنجاح", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void VendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (VendorNameTextBox.Text != string.Empty && VendorContactTextBox.Text != string.Empty)
            {
                EditVendorButton.Enabled = true;
            }
            else
            {
                EditVendorButton.Enabled = false;

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
