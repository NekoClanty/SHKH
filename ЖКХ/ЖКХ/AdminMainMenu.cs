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

namespace ЖКХ
{
    public partial class AdminMainMenu : Form
    {
        DB db = new DB();
        public int A()
        {
            SqlCommand command = new SqlCommand ("SELECT COUNT(*) FROM Задолженность", db.getConnection());
            int count = 0;
            db.openConnection();
            count = (int)command.ExecuteScalar();
            return count;
        }
        public AdminMainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public int i;
        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Клиент.Фамилия, Клиент.Имя, Клиент.Отчество, Клиент.Телефон, Клиент.Улица, Клиент.Дом, Клиент.Квартира, Задолженность.Задолженность, Услуги.[Вид услуги]  From Клиент, Задолженность, Услуги  Where Задолженность  > 0 AND Клиент.ID_клиента = Задолженность.ID_клиента AND Услуги.ID_услуги = Задолженность.ID_услуги", db.getConnection());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                SurnameBox.Text = dataReader.GetValue(0).ToString();
                NameBox.Text = dataReader.GetValue(1).ToString();
                MiddleNameBox.Text = dataReader.GetValue(2).ToString();
                TelephoneTextBox.Text = dataReader.GetValue(3).ToString();
                AddressTextBox.Text = "Улица " + dataReader.GetValue(4).ToString()+ ", дом " + dataReader.GetValue(5).ToString() + ", квартира " + dataReader.GetValue(6).ToString();
                DebtAmountTextBox.Text = dataReader.GetValue(7).ToString() + " руб.";
                ServiceTextBox.Text = dataReader.GetValue(8).ToString();
            }
            db.closeConnection();
            SurnameBox.Enabled = false;
            NameBox.Enabled = false;
            MiddleNameBox.Enabled = false;
            TelephoneTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            DebtAmountTextBox.Enabled = false;
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            i++;
            if (i > A()) i = A(); 
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Клиент.Фамилия, Клиент.Имя, Клиент.Отчество, Клиент.Телефон, Клиент.Улица, Клиент.Дом, Клиент.Квартира, Задолженность.Задолженность,  Услуги.[Вид услуги]  From Клиент, Задолженность, Услуги  Where Задолженность  > 0 AND Клиент.ID_клиента = Задолженность.ID_клиента AND Задолженность.ID_клиента = @userid AND Услуги.ID_услуги = Задолженность.ID_услуги", db.getConnection());
            command.Parameters.Add("@userid", SqlDbType.Int).Value = i;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                SurnameBox.Text = dataReader.GetValue(0).ToString();
                NameBox.Text = dataReader.GetValue(1).ToString();
                MiddleNameBox.Text = dataReader.GetValue(2).ToString();
                TelephoneTextBox.Text = dataReader.GetValue(3).ToString();
                AddressTextBox.Text = "Улица " + dataReader.GetValue(4).ToString() + ", дом " + dataReader.GetValue(5).ToString() + ", квартира " + dataReader.GetValue(6).ToString();
                DebtAmountTextBox.Text = dataReader.GetValue(7).ToString() + " руб.";
                ServiceTextBox.Text = dataReader.GetValue(8).ToString();
            }
            db.closeConnection();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 1) i = 1;
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Клиент.Фамилия, Клиент.Имя, Клиент.Отчество, Клиент.Телефон, Клиент.Улица, Клиент.Дом, Клиент.Квартира, Задолженность.Задолженность, Услуги.[Вид услуги]  From Клиент, Задолженность, Услуги  Where Задолженность  > 0 AND Клиент.ID_клиента = Задолженность.ID_клиента AND Задолженность.ID_клиента = @userid AND Услуги.ID_услуги = Задолженность.ID_услуги", db.getConnection());
            command.Parameters.Add("@userid", SqlDbType.Int).Value = i;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                SurnameBox.Text = dataReader.GetValue(0).ToString();
                NameBox.Text = dataReader.GetValue(1).ToString();
                MiddleNameBox.Text = dataReader.GetValue(2).ToString();
                TelephoneTextBox.Text = dataReader.GetValue(3).ToString();
                AddressTextBox.Text = "Улица " + dataReader.GetValue(4).ToString() + ", дом " + dataReader.GetValue(5).ToString() + ", квартира " + dataReader.GetValue(6).ToString();
                DebtAmountTextBox.Text = dataReader.GetValue(7).ToString() + " руб.";
                ServiceTextBox.Text = dataReader.GetValue(8).ToString();
            }
            db.closeConnection();
        }
    }
}
