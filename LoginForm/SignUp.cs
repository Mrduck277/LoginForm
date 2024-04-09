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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void QuitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButt_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void ClearIn_Click(object sender, EventArgs e)
        {
            UserInput2.Clear();
            PassInput.Clear();
            PassConInput.Clear();
            UserInput2.Focus();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void PassMatchError_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButt_Click(object sender, EventArgs e)
        {
            if (UserInput2.Text == "Admin")
            {
                PassMatchError.Visible = false;
                errorBox.Visible = true;
            }
            else if (PassInput.Text != PassConInput.Text)
            {
                errorBox.Visible = false;
                PassMatchError.Visible = true;
            }
            else
            {
                MessageBox.Show("You are now signed up!");
            }
        }
    }
}
