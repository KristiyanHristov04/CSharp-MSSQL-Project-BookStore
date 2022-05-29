using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Online_Book_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void haveAccount_MouseHover(object sender, EventArgs e)
        {
            haveAccount.ForeColor = Color.ForestGreen;

        }

        private void haveAccount_MouseLeave(object sender, EventArgs e)
        {
            haveAccount.ForeColor = Color.DarkSeaGreen;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (txtPassword.Text == "")
            {
                labelPasswordWarning.Visible = true;
                redTriangle02.Visible = true;
                isValid = false;
            }
            else
            {
                labelPasswordWarning.Visible = false;
                
                isValid = true;
            }

            if (txtConfirmPassword.Text == "")
            {
               labelCPasswordWarning.Visible = true;
                redTriangle03.Visible = true;
                isValid = false;
            }
            else
            {
                labelCPasswordWarning.Visible = false;
                isValid = true;
            }
            if (txtUsername.Text != "")
            {
                labelUsernameWarning.Visible = false;
                redTriangle01.Visible = false;
                isValid = true;
            }
            if (txtPassword.Text == txtConfirmPassword.Text && txtUsername.Text == "" 
                && (txtPassword.Text != "" && txtConfirmPassword.Text != ""))
            {
                redTriangle02.Visible = false;
                redTriangle03.Visible = false;
                labelpasswordDoNotMatch.Visible = false;
                labelCpasswordDoNotMatch.Visible = false;
            }
            if (txtPassword.Text != "" && txtConfirmPassword.Text != "" && 
                txtPassword.Text != txtConfirmPassword.Text && txtUsername.Text == "")
            {
                labelpasswordDoNotMatch.Visible = true;
                labelCpasswordDoNotMatch.Visible = true;
            }

            if (txtUsername.Text == "")
            {
                labelUsernameWarning.Visible = true;
                redTriangle01.Visible = true;
                isValid = false;
            }           
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text && isValid == true && 
                    (txtPassword.Text != "" && txtConfirmPassword.Text != ""))
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KrisPC\OneDrive\Documents\regg.mdf;Integrated Security=True;Connect Timeout=30");
                    String str = "insert into regg(username,password,cpassword) values ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtConfirmPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    redTriangle02.Visible = false;
                    redTriangle03.Visible = false;
                    labelUsernameWarning.Visible = false;
                    labelpasswordDoNotMatch.Visible = false;
                    labelCpasswordDoNotMatch.Visible = false;
                    labelCPasswordWarning.Visible = false;
                    labelPasswordWarning.Visible = false;

                    //MessageBox.Show("Registration Successfull.");

                    

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else if(txtPassword.Text != txtConfirmPassword.Text && isValid == true)
                {
                    labelpasswordDoNotMatch.Visible = true;
                    labelCpasswordDoNotMatch.Visible = true;
                    redTriangle02.Visible = true;
                    redTriangle03.Visible = true;
                    //MessageBox.Show("Passwords does not match! Please Re-enter them.");
                }
            }

        }

        private void haveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void labelUsernameWarning_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHidePassword_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPassword.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShowPassword_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnShowCPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
            {
                btnHideCPassword.BringToFront();
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnHideCPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                btnShowCPassword.BringToFront();
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
