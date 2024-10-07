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
    public partial class AddNewCatalogView : Form
    {
        public AddNewCatalogView()
        {
            InitializeComponent();
        }

        private void AddCatalogButton_Click(object sender, EventArgs e)
        {
            if (CatalogNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم الكتالوج فارغة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int rowsCount = CatalogsController.PROCEDURE_ADDNEWCATALOG(CatalogNameTextBox.Text);
            MessageBox.Show("تم إضافة الكتالوج بنجاح \n عدد الصفوف المضافة حديثا" + rowsCount, "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
