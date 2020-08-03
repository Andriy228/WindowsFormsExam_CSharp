using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsExam_CSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static public int GetId { get; set; }
      

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Login_button_Click_1(object sender, EventArgs e)
        {
            bool s = false;
            if (LoginTextBox.Text != "" || PassTextBox.Text != "")
            {
                using (var context = new DB())
                {
                    foreach (var item in context.Users)
                    {
                        if (LoginTextBox.Text == item.Login && PassTextBox.Text == item.Password)
                        {
                            GetId = item.Id;
                            this.Hide();
                            FormProfile formProfile = new FormProfile();
                            formProfile.Show();
                        }
                        else
                        {
                            s = true;
                        }
                    }
                }
            }
            if (LoginTextBox.Text == "" || PassTextBox.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ToRegistrationButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (PassTextBox.UseSystemPasswordChar)
            {
                PassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassTextBox.UseSystemPasswordChar = true;
            }
        }

    }
}
