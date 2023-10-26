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
    public partial class PersonalUser : Form
    {
        public PersonalUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        DB db = new DB();
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
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
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
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
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
        private void PersonalUser_Load(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Фамилия, Имя, Отчество, Телефон, Улица, Дом, Квартира, Логин, Пароль From Клиент Where ID_клиента = @userid", db.getConnection());
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Login.UserID;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                SurnameBox.Text = dataReader.GetValue(0).ToString();
                NameBox.Text = dataReader.GetValue(1).ToString();
                MiddleNameBox.Text = dataReader.GetValue(2).ToString();
                TelephoneTextBox.Text = dataReader.GetValue(3).ToString();
                StreetTextBox.Text = dataReader.GetValue(4).ToString();
                HouseNumberTextBox.Text = dataReader.GetValue(5).ToString();
                ApartmentNumberTextBox.Text = dataReader.GetValue(6).ToString();
                LoginBox.Text = dataReader.GetValue(7).ToString();
                PasswordBox.Text = dataReader.GetValue(8).ToString();
            }
            db.closeConnection();
            SurnameBox.Enabled = false;
            NameBox.Enabled = false;
            MiddleNameBox.Enabled = false;
            TelephoneTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            HouseNumberTextBox.Enabled = false;
            ApartmentNumberTextBox.Enabled = false;
            LoginBox.Enabled = false;
            PasswordBox.Enabled = false;
            ChangeButton.Visible = true;
            CancelButton.Visible = false;
            SaveButton.Visible = false;
            ReceiptButton.Visible = true;
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            SurnameBox.Enabled = true;
            NameBox.Enabled = true;
            MiddleNameBox.Enabled = true;
            TelephoneTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            HouseNumberTextBox.Enabled = true;
            ApartmentNumberTextBox.Enabled = true;
            LoginBox.Enabled = true;
            PasswordBox.Enabled = true;
            ChangeButton.Visible = false;
            CancelButton.Visible = true;
            SaveButton.Visible = true;
            ReceiptButton.Visible = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
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
            else
            {
                SqlCommand command = new SqlCommand("UPDATE [Клиент] SET Фамилия = @surname, Имя = @name, Отчество = @middlename, Телефон = @telephone, Улица = @street, Дом = @house, Квартира = @apartment, Логин = @login, Пароль =  @password WHERE ID_клиента = @userid", db.getConnection());
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = SurnameBox.Text;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameBox.Text;
                command.Parameters.Add("@middlename", SqlDbType.NVarChar).Value = MiddleNameBox.Text;
                command.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = TelephoneTextBox.Text;
                command.Parameters.Add("@street", SqlDbType.NVarChar).Value = StreetTextBox.Text;
                command.Parameters.Add("@house", SqlDbType.NVarChar).Value = HouseNumberTextBox.Text;
                command.Parameters.Add("@apartment", SqlDbType.NVarChar).Value = ApartmentNumberTextBox.Text;
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = LoginBox.Text;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = PasswordBox.Text;
                command.Parameters.Add("@userid", SqlDbType.Int).Value = Login.UserID;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные сохранены", "Успех!");
                    SurnameBox.Enabled = false;
                    NameBox.Enabled = false;
                    MiddleNameBox.Enabled = false;
                    TelephoneTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    HouseNumberTextBox.Enabled = false;
                    ApartmentNumberTextBox.Enabled = false;
                    LoginBox.Enabled = false;
                    PasswordBox.Enabled = false;
                    ChangeButton.Visible = true;
                    CancelButton.Visible = false;
                    SaveButton.Visible = false;
                    ReceiptButton.Visible = true;
                }
                else
                    MessageBox.Show("Данные не сохранены", "Ошибка");
                db.closeConnection();
            }
        }
        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            Receipt newForm = new Receipt();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
