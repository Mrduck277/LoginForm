using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private static bool CheckUserNameAndPass(string RowChecking, string thingToCheck, string password ,string con)
        {
            bool IfThere = false;
            //"data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=PhoneBookData;integrated security=True;Encrypt=False"

            var conn = new SqlConnection(con);
            conn.Open();
            string insertString = $"select count(*) from loginAndPassword where (UserName = '{thingToCheck}' and UserPassword = '{password}');";

            /*SqlCommand CheckNumber = new SqlCommand(insertString, conn);
            CheckNumber.Parameters.AddWithValue(RowChecking, thingToCheck);
            int NumberExist = (int)CheckNumber.ExecuteScalar();*/

            SqlCommand Checking = new SqlCommand(insertString, conn);
            Checking.Parameters.AddWithValue("@UserName", thingToCheck);
            Checking.Parameters.AddWithValue("@UserPassword", thingToCheck);
            int Num = (int)Checking.ExecuteScalar();


            if (Num > 0)
            {
                IfThere = true;
            }
            else
            {
                IfThere = false;
            }
            conn.Close();


            return IfThere;
        }


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
            bool isThere = CheckUserNameAndPass("UserName", UserInput.Text, PassInput.Text , "data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=LoginAndSignup;integrated security=True;Encrypt=False");

            if (isThere)
            {
                MessageBox.Show("You are logged in!");
            }
            else if(!isThere)
            {
                errorBox.Visible = true;
            }
            else
            {
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
