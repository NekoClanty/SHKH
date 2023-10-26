
namespace ЖКХ
{
    partial class Registration
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
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.ApartmentNumberLabel = new System.Windows.Forms.Label();
            this.HouseNumberLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(520, 374);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(221, 41);
            this.PasswordBox.TabIndex = 41;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(293, 374);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(221, 41);
            this.LoginBox.TabIndex = 40;
            this.LoginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginBox_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(514, 322);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(102, 33);
            this.PasswordLabel.TabIndex = 39;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.Location = new System.Drawing.Point(261, 443);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(277, 74);
            this.RegistrationButton.TabIndex = 38;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(176, 20);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(203, 40);
            this.RegistrationLabel.TabIndex = 37;
            this.RegistrationLabel.Text = "Регистрация";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(287, 322);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(92, 33);
            this.LoginLabel.TabIndex = 36;
            this.LoginLabel.Text = "Логин";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(514, 101);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(130, 33);
            this.MiddleNameLabel.TabIndex = 35;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(287, 101);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 33);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(60, 101);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(127, 33);
            this.SurnameLabel.TabIndex = 33;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameBox.Location = new System.Drawing.Point(520, 166);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(221, 41);
            this.MiddleNameBox.TabIndex = 32;
            this.MiddleNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MiddleNameBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(293, 166);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(221, 41);
            this.NameBox.TabIndex = 31;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(66, 166);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(221, 41);
            this.SurnameBox.TabIndex = 30;
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameBox_KeyPress);
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.TelephoneLabel.Location = new System.Drawing.Point(60, 221);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(121, 33);
            this.TelephoneLabel.TabIndex = 43;
            this.TelephoneLabel.Text = "Телефон";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.StreetLabel.Location = new System.Drawing.Point(287, 221);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(91, 33);
            this.StreetLabel.TabIndex = 44;
            this.StreetLabel.Text = "Улица";
            // 
            // ApartmentNumberLabel
            // 
            this.ApartmentNumberLabel.AutoSize = true;
            this.ApartmentNumberLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.ApartmentNumberLabel.Location = new System.Drawing.Point(60, 322);
            this.ApartmentNumberLabel.Name = "ApartmentNumberLabel";
            this.ApartmentNumberLabel.Size = new System.Drawing.Size(129, 33);
            this.ApartmentNumberLabel.TabIndex = 45;
            this.ApartmentNumberLabel.Text = "Квартира";
            // 
            // HouseNumberLabel
            // 
            this.HouseNumberLabel.AutoSize = true;
            this.HouseNumberLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.HouseNumberLabel.Location = new System.Drawing.Point(514, 221);
            this.HouseNumberLabel.Name = "HouseNumberLabel";
            this.HouseNumberLabel.Size = new System.Drawing.Size(66, 33);
            this.HouseNumberLabel.TabIndex = 46;
            this.HouseNumberLabel.Text = "Дом";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(293, 269);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(221, 41);
            this.StreetTextBox.TabIndex = 48;
            this.StreetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetTextBox_KeyPress);
            // 
            // HouseNumberTextBox
            // 
            this.HouseNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumberTextBox.Location = new System.Drawing.Point(520, 269);
            this.HouseNumberTextBox.Name = "HouseNumberTextBox";
            this.HouseNumberTextBox.Size = new System.Drawing.Size(221, 41);
            this.HouseNumberTextBox.TabIndex = 49;
            this.HouseNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseNumberTextBox_KeyPress);
            // 
            // ApartmentNumberTextBox
            // 
            this.ApartmentNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartmentNumberTextBox.Location = new System.Drawing.Point(66, 374);
            this.ApartmentNumberTextBox.Name = "ApartmentNumberTextBox";
            this.ApartmentNumberTextBox.Size = new System.Drawing.Size(221, 41);
            this.ApartmentNumberTextBox.TabIndex = 50;
            this.ApartmentNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApartmentNumberTextBox_KeyPress);
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 21.75F);
            this.TelephoneTextBox.Location = new System.Drawing.Point(66, 269);
            this.TelephoneTextBox.Mask = "+7(999)000-00-00";
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(221, 41);
            this.TelephoneTextBox.TabIndex = 51;
            this.TelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneTextBox_KeyPress);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 574);
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
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(825, 613);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label ApartmentNumberLabel;
        private System.Windows.Forms.Label HouseNumberLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox HouseNumberTextBox;
        private System.Windows.Forms.TextBox ApartmentNumberTextBox;
        private System.Windows.Forms.MaskedTextBox TelephoneTextBox;
    }
}