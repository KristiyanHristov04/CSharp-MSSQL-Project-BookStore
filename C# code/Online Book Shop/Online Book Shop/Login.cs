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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void haveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void haveAccount_MouseHover(object sender, EventArgs e)
        {
            noAccount.ForeColor = Color.ForestGreen;
        }

        private void haveAccount_MouseLeave(object sender, EventArgs e)
        {
            noAccount.ForeColor = Color.DarkSeaGreen;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                labelNoUsername.Visible = true;
                redTriangle01.Visible = true;
            }
            else
            {
                labelNoUsername.Visible = false;
                redTriangle01.Visible = false;
            }

            if (txtPassword.Text == "")
            {
                labelNoPassword.Visible = true;
                redTriangle02.Visible = true;
                
            }
            else
            {
                labelNoPassword.Visible = false;
                redTriangle02.Visible = false;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KrisPC\OneDrive\Documents\regg.mdf;Integrated Security=True;Connect Timeout=30");
            String str1 = "select username,password,cpassword from regg where username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                labelNoUsername.Visible = false;
                labelNoPassword.Visible = false;
                labelWrongInformation.Visible = false;
                //MessageBox.Show("Log In Successfull.");
                this.Hide();
                Main_Page mainPage = new Main_Page();
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                //MessageBox.Show("Incorrect Username or Password!");
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    labelWrongInformation.Visible = true;
                }
                else
                {
                    labelWrongInformation.Visible = false;
                }
                
            }

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KrisPC\OneDrive\Documents\regg.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From regg where username='" + txtUsername + "' and password='"+txtPassword+ "''", con);
            //DataTable dt = new DataTable();



            
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPassword.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
