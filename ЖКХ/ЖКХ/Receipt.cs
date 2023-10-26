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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        DB db = new DB();
        public int A()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Услуги", db.getConnection());
            int count = 0;
            db.openConnection();
            count = (int)command.ExecuteScalar();
            return count;
        }
        public int i;
        private void Receipt_Load(object sender, EventArgs e)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Фамилия, Имя, Отчество, Улица, Дом, Квартира  From Клиент Where ID_клиента = @userid", db.getConnection());
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Login.UserID;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                FullNameBox.Text = dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(1).ToString() + " " + dataReader.GetValue(2).ToString();
                AddressTextBox.Text = "Улица " + dataReader.GetValue(3).ToString() + ", дом " + dataReader.GetValue(4).ToString() + ", квартира " + dataReader.GetValue(5).ToString();
            }
            db.closeConnection();
            db.openConnection();
            SqlCommand command1 = new SqlCommand("Select Услуги.[Вид услуги], Услуги.[Единица измерения], Услуги.Тариф From Услуги ", db.getConnection());
            SqlDataReader dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                ServiceTextBox.Text = dataReader1.GetValue(0).ToString();
                RateTextBox.Text = dataReader1.GetValue(2).ToString() + " за 1 " + dataReader1.GetValue(1).ToString();
            }
            db.closeConnection();
            db.openConnection();
            SqlCommand command2 = new SqlCommand("Select Услуги.[Вид услуги], Задолженность.Задолженность From Услуги, Задолженность WHERE Услуги.ID_услуги = Задолженность.ID_услуги AND Задолженность.ID_клиента = @userid  ", db.getConnection());
            command2.Parameters.Add("@userid", SqlDbType.Int).Value = Login.UserID;
            SqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                DebtAmountLabel.Text = "Задолженность за " + dataReader2.GetValue(0).ToString();
                DebtAmountTextBox.Text = dataReader2.GetValue(1).ToString();
                if (Convert.ToInt32(DebtAmountTextBox.Text) > 0)
                { PayButton.Visible = true; }
                DebtAmountTextBox.Text = dataReader2.GetValue(1).ToString() + " руб";
            }
            db.closeConnection();
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            i++;
            if (i > A()) i = A();
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Услуги.[Вид услуги], Услуги.[Единица измерения], Услуги.Тариф  From Услуги WHERE Услуги.ID_услуги = @id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = i;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ServiceTextBox.Text = dataReader.GetValue(0).ToString();
                RateTextBox.Text = dataReader.GetValue(2).ToString() + " за 1 " + dataReader.GetValue(1).ToString();
            }
            db.closeConnection();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 1) i = 1;
            db.openConnection();
            SqlCommand command = new SqlCommand("Select Услуги.[Вид услуги], Услуги.[Единица измерения], Услуги.Тариф  From Услуги WHERE Услуги.ID_услуги = @id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = i;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ServiceTextBox.Text = dataReader.GetValue(0).ToString();
                RateTextBox.Text = dataReader.GetValue(2).ToString() + " за 1 " + dataReader.GetValue(1).ToString();
            }
            db.closeConnection();
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Задолженность SET Задолженность = 0 WHERE ID_клиента = @userid", db.getConnection());
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Login.UserID;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Оплата прошла успешна", "Успех!");
                this.Close();
            }
            else
                MessageBox.Show("Оплата не прошла", "Ошибка");
            db.closeConnection();
        }
    }
}
