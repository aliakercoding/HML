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
    public partial class AddNewSectionView : Form
    {
        public AddNewSectionView()
        {
            InitializeComponent();
        }

        private void AddSectionButton_Click(object sender, EventArgs e)
        {
            if (SectionNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم القسم فارغة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int rowsCount = SectionsController.PROCEDURE_ADDNEWSECTION(SectionNameTextBox.Text);
            MessageBox.Show("تم إضافة القسم بنجاح \n عدد الصفوف المضافة حديثا" + rowsCount, "تم الإعتماد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
