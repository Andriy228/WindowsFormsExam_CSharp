using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExam_CSharp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            NameTextBox.Text = "Введіть ім'я"; NameTextBox.ForeColor = Color.Gray;
            EmailTextBox.Text = "Введіть email"; EmailTextBox.ForeColor = Color.Gray;
            LoginTextBox.Text = "Введіть login"; LoginTextBox.ForeColor = Color.Gray;
            PassTextBox.Text = "Введіть пароль"; PassTextBox.ForeColor = Color.Gray;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToLoginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        Point lastPoint;

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void NameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (NameTextBox.Text == "Введіть ім'я")
            {
                NameTextBox.Text = "";
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Введіть ім'я"; NameTextBox.ForeColor = Color.Gray;
            }
        }

        private void EmailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EmailTextBox.Text == "Введіть email")
            {
                EmailTextBox.Text = "";
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "Введіть email"; EmailTextBox.ForeColor = Color.Gray;
            }
        }

        private void LoginTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LoginTextBox.Text == "Введіть login")
            {
                LoginTextBox.Text = "";
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Введіть login"; LoginTextBox.ForeColor = Color.Gray;
            }
        }

        private void PassTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (PassTextBox.Text == "Введіть пароль")
            {
                PassTextBox.Text = "";
            }
        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            if (PassTextBox.Text == "")
            {
                PassTextBox.Text = "Введіть пароль"; PassTextBox.ForeColor = Color.Gray;
            }
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (!SubmitCheckBox.Checked)
            {
                MessageBox.Show("Підтвердіть ваші дії", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NameTextBox.Text == "Введіть ім'я" || EmailTextBox.Text == "Введіть email" || LoginTextBox.Text == "Введіть login" || PassTextBox.Text == "Введіть пароль")
            {
                MessageBox.Show("Заповніть всі поля!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!StringIsValid(LoginTextBox.Text) || !StringIsValid(NameTextBox.Text) || !StringIsValid(PassTextBox.Text))
            {
                MessageBox.Show("Не корректно введено дані");
            }
            else if (!IsValidEmail(EmailTextBox.Text))
            {
            }
            else if (NameTextBox.Text != "Введіть ім'я" || EmailTextBox.Text != "Введіть email" || LoginTextBox.Text != "Введіть login" || PassTextBox.Text != "Введіть пароль")
            {
                using (var context = new DB())
                {
                    var us = new User()
                    {
                        Name = NameTextBox.Text,
                        Email = EmailTextBox.Text,
                        Login = LoginTextBox.Text,
                        Password = PassTextBox.Text
                    };

                    context.Users.Add(us);
                    context.SaveChanges();

                    MessageBox.Show("Реєстрація пройшла успішно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }
        public bool StringIsValid(string str)
        {
            return !Regex.IsMatch(str, @"[^a-zA-z\d_]{2,9}");
        }

        public bool IsValidEmail(string email)
        {
            bool x = false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Host != "gmail.com" && addr.Host != "meta.ua" && addr.Address != email)
                {
                    x = false;
                    MessageBox.Show("Такої адреси пошти не існує!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    x = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return x;
        }
    }
}
