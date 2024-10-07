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
    public partial class AddNewBrandView : Form
    {
        public AddNewBrandView()
        {
            InitializeComponent();
        }

        private void AddBrandButton_Click(object sender, EventArgs e)
        {
            if (BrandNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم الكتالوج فارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsCount = BrandsController.PROCEDURE_ADDNEWBRAND(BrandNameTextBox.Text);
            MessageBox.Show(" تم إضافة العلامة التجارية " + BrandNameTextBox.Text + " بنجاح ", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
