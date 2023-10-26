
namespace ЖКХ
{
    partial class PersonalUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TelephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ApartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumberLabel = new System.Windows.Forms.Label();
            this.ApartmentNumberLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PersonalUserLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Enabled = false;
            this.TelephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.TelephoneTextBox.Location = new System.Drawing.Point(66, 236);
            this.TelephoneTextBox.Mask = "+7(999)000-00-00";
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(221, 41);
            this.TelephoneTextBox.TabIndex = 69;
            // 
            // ApartmentNumberTextBox
            // 
            this.ApartmentNumberTextBox.Enabled = false;
            this.ApartmentNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartmentNumberTextBox.Location = new System.Drawing.Point(66, 341);
            this.ApartmentNumberTextBox.Name = "ApartmentNumberTextBox";
            this.ApartmentNumberTextBox.Size = new System.Drawing.Size(221, 41);
            this.ApartmentNumberTextBox.TabIndex = 68;
            this.ApartmentNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApartmentNumberTextBox_KeyPress);
            // 
            // HouseNumberTextBox
            // 
            this.HouseNumberTextBox.Enabled = false;
            this.HouseNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumberTextBox.Location = new System.Drawing.Point(520, 236);
            this.HouseNumberTextBox.Name = "HouseNumberTextBox";
            this.HouseNumberTextBox.Size = new System.Drawing.Size(221, 41);
            this.HouseNumberTextBox.TabIndex = 67;
            this.HouseNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseNumberTextBox_KeyPress);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Enabled = false;
            this.StreetTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(293, 236);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(221, 41);
            this.StreetTextBox.TabIndex = 66;
            this.StreetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetTextBox_KeyPress);
            // 
            // HouseNumberLabel
            // 
            this.HouseNumberLabel.AutoSize = true;
            this.HouseNumberLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.HouseNumberLabel.Location = new System.Drawing.Point(514, 188);
            this.HouseNumberLabel.Name = "HouseNumberLabel";
            this.HouseNumberLabel.Size = new System.Drawing.Size(66, 33);
            this.HouseNumberLabel.TabIndex = 65;
            this.HouseNumberLabel.Text = "Дом";
            // 
            // ApartmentNumberLabel
            // 
            this.ApartmentNumberLabel.AutoSize = true;
            this.ApartmentNumberLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.ApartmentNumberLabel.Location = new System.Drawing.Point(60, 289);
            this.ApartmentNumberLabel.Name = "ApartmentNumberLabel";
            this.ApartmentNumberLabel.Size = new System.Drawing.Size(129, 33);
            this.ApartmentNumberLabel.TabIndex = 64;
            this.ApartmentNumberLabel.Text = "Квартира";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.StreetLabel.Location = new System.Drawing.Point(287, 188);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(91, 33);
            this.StreetLabel.TabIndex = 63;
            this.StreetLabel.Text = "Улица";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.TelephoneLabel.Location = new System.Drawing.Point(60, 188);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(121, 33);
            this.TelephoneLabel.TabIndex = 62;
            this.TelephoneLabel.Text = "Телефон";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Enabled = false;
            this.PasswordBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(520, 341);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(221, 41);
            this.PasswordBox.TabIndex = 61;
            // 
            // LoginBox
            // 
            this.LoginBox.Enabled = false;
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(293, 341);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(221, 41);
            this.LoginBox.TabIndex = 60;
            this.LoginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginBox_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(514, 289);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(102, 33);
            this.PasswordLabel.TabIndex = 59;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(287, 289);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(92, 33);
            this.LoginLabel.TabIndex = 58;
            this.LoginLabel.Text = "Логин";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(514, 68);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(130, 33);
            this.MiddleNameLabel.TabIndex = 57;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(287, 68);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 33);
            this.NameLabel.TabIndex = 56;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(60, 68);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(127, 33);
            this.SurnameLabel.TabIndex = 55;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Enabled = false;
            this.MiddleNameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameBox.Location = new System.Drawing.Point(520, 133);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(221, 41);
            this.MiddleNameBox.TabIndex = 54;
            this.MiddleNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MiddleNameBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(293, 133);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(221, 41);
            this.NameBox.TabIndex = 53;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Enabled = false;
            this.SurnameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(66, 133);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(221, 41);
            this.SurnameBox.TabIndex = 52;
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameBox_KeyPress);
            // 
            // PersonalUserLabel
            // 
            this.PersonalUserLabel.AutoSize = true;
            this.PersonalUserLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalUserLabel.Location = new System.Drawing.Point(287, 9);
            this.PersonalUserLabel.Name = "PersonalUserLabel";
            this.PersonalUserLabel.Size = new System.Drawing.Size(223, 33);
            this.PersonalUserLabel.TabIndex = 70;
            this.PersonalUserLabel.Text = "Личный кабинет";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.ChangeButton.Location = new System.Drawing.Point(272, 410);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(262, 47);
            this.ChangeButton.TabIndex = 71;
            this.ChangeButton.Text = "Изменить данные";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.SaveButton.Location = new System.Drawing.Point(540, 410);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(153, 47);
            this.SaveButton.TabIndex = 72;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.CancelButton.Location = new System.Drawing.Point(113, 410);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(153, 47);
            this.CancelButton.TabIndex = 73;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.PersonalUser_Load);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.ReceiptButton.Location = new System.Drawing.Point(272, 463);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(262, 47);
            this.ReceiptButton.TabIndex = 74;
            this.ReceiptButton.Text = "Квитанция";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // PersonalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PersonalUserLabel);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.ApartmentNumberTextBox);
            this.Controls.Add(this.HouseNumberTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.HouseNumberLabel);
            this.Controls.Add(this.ApartmentNumberLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(816, 570);
            this.Name = "PersonalUser";
            this.Text = "PersonalUser";
            this.Load += new System.EventHandler(this.PersonalUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox ApartmentNumberTextBox;
        private System.Windows.Forms.TextBox HouseNumberTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label HouseNumberLabel;
        private System.Windows.Forms.Label ApartmentNumberLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label PersonalUserLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ReceiptButton;
    }
}