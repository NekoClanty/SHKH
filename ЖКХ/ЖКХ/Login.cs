using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ЖКХ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public static bool UserOrAdmin { get; set; }
        public static int UserID { get; private set; }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (UserRadioButton.Checked)
            {
                String LoginUser = LoginBox.Text;
                String PasswordUser = PasswordBox.Text;
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("Select * FROM [Клиент] WHERE Логин = @LU AND Пароль = @PU", db.getConnection());
                command.Parameters.Add("@LU", SqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@PU", SqlDbType.VarChar).Value = PasswordUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < UserDataGridView.Rows.Count - 1; i++)
                    {
                        if (Convert.ToString(UserDataGridView.Rows[i].Cells[1].Value) == LoginUser)
                        {
                            UserID = Convert.ToInt32(UserDataGridView.Rows[i].Cells[0].Value);
                        }
                    }
                    MessageBox.Show("Вход выполнен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonalUser newForm = new PersonalUser();
                    this.Hide();
                    newForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Вход не выполнен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (AdministratorRadioButton.Checked)
            {
                String LoginAdmin = LoginBox.Text;
                String PasswordAdmin = PasswordBox.Text;
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("Select * FROM Администратор WHERE Логин = @LA AND Пароль = @PA", db.getConnection());
                command.Parameters.Add("@LA", SqlDbType.VarChar).Value = LoginAdmin;
                command.Parameters.Add("@PA", SqlDbType.VarChar).Value = PasswordAdmin;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Вход выполнен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainMenu newForm = new AdminMainMenu();
                    this.Hide();
                    newForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Вход не выполнен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Роль в системе не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (AdministratorRadioButton.Checked == false && UserRadioButton.Checked == false)
            {
                MessageBox.Show("Выберите роль, для регистрации в системе", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AdministratorRadioButton.Checked)
            {
                AdminPassword newForm = new AdminPassword();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
            }
            else
            {
                UserOrAdmin = false;
                Registration newForm = new Registration();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string L = $"select ID_клиента, Логин, Пароль from [Клиент]";
            SqlDataAdapter adapter = new SqlDataAdapter(L, new DB().getConnection());
            DataSet D = new DataSet(); adapter.Fill(D, "[Клиент]"); UserDataGridView.DataSource = D.Tables["[Клиент]"].DefaultView;
        }
    }
}
