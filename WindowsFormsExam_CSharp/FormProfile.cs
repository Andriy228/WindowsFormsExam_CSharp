using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsExam_CSharp
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            GetAllCustomers();
        }
        public void GetAllCustomers()
        {
            var context = new DB();

            foreach (var customer in context.Users.Where(c => c.Id == LoginForm.GetId))
            {
                label2.Text = customer.Login;
                label7.Text = customer.Login;
                label8.Text = customer.Email;
                label9.Text = customer.Name;
                label10.Text = customer.Password;
                label12.Text = Convert.ToString(customer.Id);
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void FormProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void FormProfile_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
