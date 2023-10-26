using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЖКХ
{
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Handsome$$2")
            {
                Login.UserOrAdmin = true;
                Registration newForm = new Registration();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Пароль неверный", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
