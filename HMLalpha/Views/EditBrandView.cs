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
    public partial class EditBrandView : Form
    {
        public EditBrandView()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BrandIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBrandView_Load(object sender, EventArgs e)
        {
            DataTable dataTable = BrandsController.PROCEDURE_SELECTBRAND(BrandsControlView.ID);
            foreach (DataRow row in dataTable.Rows)
            {
                BrandIdTextBox.Text = row["BRAND_ID"].ToString();
                BrandNameTextBox.Text = row["BRAND_NAME"].ToString();

            }
        }

        private void EditBrandButton_Click(object sender, EventArgs e)
        {
            if (BrandNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم الكتالوج فارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int rowsCount = BrandsController.PROCEDURE_UPDATEBRAND(int.Parse(BrandIdTextBox.Text), BrandNameTextBox.Text);
                                MessageBox.Show("تم تعديل بيانات العلامة التجارية بنجاح", "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}