using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ЖКХ
{
    public partial class Registration : Form
    {
        DB db = new DB();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            if (Login.UserOrAdmin == true)
            { RegistrationLabel.Text = "Регистрация администратора"; 
              SurnameLabel.Visible = false; NameLabel.Visible = false; MiddleNameLabel.Visible = false;  TelephoneLabel.Visible = false; StreetLabel.Visible = false; HouseNumberLabel.Visible = false; ApartmentNumberLabel.Visible = false;
              SurnameBox.Visible = false; NameBox.Visible = false; MiddleNameBox.Visible = false; TelephoneTextBox.Visible = false; StreetTextBox.Visible = false; HouseNumberTextBox.Visible = false; ApartmentNumberTextBox.Visible = false;
                LoginLabel.Location = new Point(60, 100);
                LoginBox.Location = new Point(66, 166);
                PasswordLabel.Location = new Point(287, 101);
                PasswordBox.Location = new Point(293, 166);
                RegistrationButton.Location = new Point(160, 260);
                RegistrationLabel.Location = new Point(59, 20);
                this.Size = new Size(600, 400);
                SurnameBox.Text = "."; NameBox.Text = "."; MiddleNameBox.Text = "."; TelephoneTextBox.Text = "."; StreetLabel.Text = "."; HouseNumberTextBox.Text = "."; ApartmentNumberTextBox.Text = ".";
            }
            if (Login.UserOrAdmin == false)
            { RegistrationLabel.Text = "Регистрация пользователя"; }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "" || SurnameBox.Text == "" || NameBox.Text == "" || MiddleNameBox.Text == "" || LoginBox.Text == "" || TelephoneTextBox.Text == "" || StreetLabel.Text == "" || HouseNumberTextBox.Text == "" || ApartmentNumberTextBox.Text == "")
            {
                MessageBox.Show("Ошибка!!! Одно из полей пустое");
                return;
            }
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");
            if (PasswordBox.Text.Length < 8 || PasswordBox.Text.Length > 20)
            {
                MessageBox.Show("Ошибка!!! Длина пароля должна быть не меньше 8 символов и не больше 20 символов");
                return;
            }
            else if (!hasNumber.IsMatch(PasswordBox.Text))
            {
                MessageBox.Show("Ошибка!!! Пароль должен иметь хотя бы одну цифру");
                return;
            }
            else if (!hasUpperChar.IsMatch(PasswordBox.Text))
            {
                MessageBox.Show("Ошибка!!! Пароль должен иметь хотя бы одну заглавную букву");
                return;
            }
            else if (!hasLowerChar.IsMatch(PasswordBox.Text))
            {
                MessageBox.Show("Ошибка!!! Пароль должен иметь хотя бы одну строчную букву");
                return;
            }
            else if (!hasSymbols.IsMatch(PasswordBox.Text))
            {
                MessageBox.Show("Ошибка!!! Пароль должен иметь хотя бы один специальный символ");
                return;
            }
            if (Login.UserOrAdmin == true)
            {
                if (checkAdmin())
                    return;
                SqlCommand command = new SqlCommand("INSERT INTO Администратор (Логин, Пароль) VALUES (@login, @password)", db.getConnection());
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = LoginBox.Text;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = PasswordBox.Text;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан", "Успех!");
                    this.Close();
                }
                else
                    MessageBox.Show("Аккаунт не создан", "Ошибка");
                db.closeConnection();
            }
            if (Login.UserOrAdmin == false)
            {
                if (checkUser())
                    return;
                SqlCommand command = new SqlCommand("INSERT INTO [Клиент] (Фамилия, Имя, Отчество, Телефон, Улица, Дом, Квартира, Логин, Пароль) VALUES (@surname, @name, @middlename, @telephone, @street, @house, @apartment, @login, @password)", db.getConnection());
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = SurnameBox.Text;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameBox.Text;
                command.Parameters.Add("@middlename", SqlDbType.NVarChar).Value = MiddleNameBox.Text;
                command.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = TelephoneTextBox.Text;
                command.Parameters.Add("@street", SqlDbType.NVarChar).Value = StreetTextBox.Text;
                command.Parameters.Add("@house", SqlDbType.NVarChar).Value = HouseNumberTextBox.Text;
                command.Parameters.Add("@apartment", SqlDbType.NVarChar).Value = ApartmentNumberTextBox.Text;
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = LoginBox.Text;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = PasswordBox.Text;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан", "Успех!");
                    this.Close();
                }
                else
                    MessageBox.Show("Аккаунт не создан", "Ошибка");
                db.closeConnection();
            }
        }
        public Boolean checkAdmin()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * FROM Администратор WHERE Логин = @LA AND Пароль = @PA", db.getConnection());
            command.Parameters.Add("@LA", SqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@PA", SqlDbType.VarChar).Value = PasswordBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * FROM [Клиент] WHERE Логин = @LU AND Пароль = @PU", db.getConnection());
            command.Parameters.Add("@LU", SqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@PU", SqlDbType.VarChar).Value = PasswordBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SurnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void MiddleNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void HouseNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') ||  e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ApartmentNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar >= '0' && e.KeyChar <= '9') ||  e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TelephoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (char.IsDigit(e.KeyChar) && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
