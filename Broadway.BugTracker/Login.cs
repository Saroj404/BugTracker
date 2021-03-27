using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broadway.BugTracker.Model;
using Broadway.BugTracker.Service;


namespace Broadway.BugTracker
{
    public partial class Login : Form
    {
        public LoginService login =new LoginService();
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Username");
            }
           if(textBox2.Text=="")
            {
                MessageBox.Show("Please enter Password");
            }

            var loginmodel = new User()
            {
                Username = textBox1.Text,
                Password=textBox2.Text
            };

            var loginResult = login.Login(loginmodel);
            if(loginResult.Item1)
            {
                //MainForm main = new MainForm();
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
                //main.Show();
            }
            else
            {
                MessageBox.Show (loginResult.Item2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
