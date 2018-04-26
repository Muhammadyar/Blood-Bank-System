using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myserver
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdLogin(object sender, EventArgs e)
        {
            bool isvalid;
            bool isvalidpassed;
            localhost.Service1 s = new localhost.Service1();

            s.isValidUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, ComboBox1.Text, out isvalid, out isvalidpassed);
            if (isvalid)
            {
                MessageBox.Show("Valid User");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }

            
        }

        private void lblRegistration(object sender, EventArgs e)
        {

       
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
