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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextbox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة إسم المستخدم فارغة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (UserPasscodeTextbox.Text == string.Empty)
            {
                MessageBox.Show("لا يمكن ترك قيمة كلمة المرور فارغة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            DataTable datatable = LoginController.PROCEDURE_LOGIN(UserNameTextbox.Text, UserPasscodeTextbox.Text);
            if (datatable.Rows.Count>0) {
                MainView.loginCheck = true;
                MessageBox.Show("أهلا بيك", "مرحبا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("إسم المستخدم أو كلمة مرور خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
