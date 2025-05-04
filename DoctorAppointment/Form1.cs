using System;
using System.Windows.Forms;

namespace DoctorAppointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String pass = txtPassword.Text;

            if (username == "das" && pass == "pass")
            {
                //MessageBox.Show("You have entered right username and password");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();

            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }
    }
}
