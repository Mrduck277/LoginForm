using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserInput.Clear();
            PassInput.Clear();
            UserInput.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserInput.Text == "Admin" &&  PassInput.Text == "Password1")
            {
                MessageBox.Show("You are logged in!");
            }
            else
            {
                errorBox.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
