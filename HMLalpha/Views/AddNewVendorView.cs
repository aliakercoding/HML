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
    public partial class AddNewVendorView : Form
    {
        public AddNewVendorView()
        {
            InitializeComponent();
        }

        private void AddNewVendorButton_Click(object sender, EventArgs e)
        {
            if (VendorNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم المورد فارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            VendorsController.PROCEDURE_ADDNEWVENDOR(VendorNameTextBox.Text, VendorContactTextBox.Text, VendorAddressTextArea.Text, decimal.Parse(VendorCreditTextBox.Text));
            MessageBox.Show(" تم إضافة المورد  " + VendorNameTextBox.Text + " بنجاح ", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void VendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (VendorNameTextBox.Text != string.Empty)
            {
                AddNewVendorButton.Enabled = true;
            }
            else
            {
                AddNewVendorButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
