using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SignUp : Form
    {

        private static bool CheckUserNameAndPass(string RowChecking, string thingToCheck, string password, string con)
        {
            bool IfThere = false;
            //"data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=PhoneBookData;integrated security=True;Encrypt=False"

            var conn = new SqlConnection(con);
            conn.Open();
            string insertString = $"select count(*) from loginAndPassword where ([{RowChecking}] = '{thingToCheck}');";

            SqlCommand CheckNumber = new SqlCommand(insertString, conn);
            CheckNumber.Parameters.AddWithValue(RowChecking, thingToCheck);
            int NumberExist = (int)CheckNumber.ExecuteScalar();

            if (NumberExist > 0)
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

        private static void AddToDatabase(string userName, string Password, string con)
        {
            var conn = new SqlConnection(con);
            string insertString = $"insert into loginAndPassword (UserName, UserPassword) values ('{userName}', '{Password}');";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


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

            bool isThere = CheckUserNameAndPass("UserName", UserInput2.Text, PassInput.Text, "data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=LoginAndSignup;integrated security=True;Encrypt=False");
            //AddToDatabase()

            if (isThere)
            {
                PassMatchError.Visible = false;
                errorBox.Visible = true;
            }
            else if (PassInput.Text.Contains(" ") || UserInput2.Text.Contains(" "))
            {
                MessageBox.Show("you can not have a space in username or password");
            }
            else if (PassInput.Text != PassConInput.Text)
            {
                errorBox.Visible = false;
                PassMatchError.Visible = true;
            }
            else
            {
                AddToDatabase(UserInput2.Text, PassInput.Text, "data source=DESKTOP-PKBTPSF\\SQLEXPRESS;initial catalog=LoginAndSignup;integrated security=True;Encrypt=False");
                SignedUp.Visible = true;
            }
        }
    }
}
