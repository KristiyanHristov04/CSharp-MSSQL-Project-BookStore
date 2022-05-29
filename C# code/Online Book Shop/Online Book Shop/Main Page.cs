using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Shop
{
    public partial class Main_Page : Form
    {
        int counter = 0;
        double bookPrice = 0;
        double totalPrice = 0;
        public Main_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void book1Price_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnBook4Order.Text == "ORDER")
            {
                counter++;
                orders.Text = counter.ToString();
                bookPrice = 22.50;
                totalPrice += bookPrice;
                currentPrice.Text = "";
                currentPrice.Text = totalPrice.ToString("0.00") + "$";
            }

            btnBook4Order.Text = "IN CART";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBook1Order_Click(object sender, EventArgs e)
        {
            if (btnBook1Order.Text == "ORDER")
            {
                counter++;
                orders.Text = counter.ToString();
                bookPrice = 15.20;
                totalPrice += bookPrice;
                currentPrice.Text = "";
                currentPrice.Text = totalPrice.ToString("0.00") + "$";
            }
            
            btnBook1Order.Text = "IN CART";

            
        }

        private void btnBook2Order_Click(object sender, EventArgs e)
        {
            if (btnBook2Order.Text == "ORDER")
            {
                counter++;
                orders.Text = counter.ToString();
                bookPrice = 18.60;
                totalPrice += bookPrice;
                currentPrice.Text = "";
                currentPrice.Text = totalPrice.ToString("0.00") + "$";

            }

            btnBook2Order.Text = "IN CART";
        }

        private void btnBook3Order_Click(object sender, EventArgs e)
        {
            if (btnBook3Order.Text == "ORDER")
            {
                counter++;
                orders.Text = counter.ToString();
                bookPrice = 12.50;
                totalPrice += bookPrice;
                currentPrice.Text = "";
                currentPrice.Text = totalPrice.ToString("0.00") + "$";
            }

            btnBook3Order.Text = "IN CART";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lblDescriptionBook1.Visible = true;
            book1Blank.Visible = true;
            labelAuthorBook1.Visible = true;
            labelAuthorBook1.BringToFront();
            labelPagesBook1.Visible = true;
            labelPagesBook1.BringToFront();
            labelPublishedBook1.Visible = true;
            labelPublishedBook1.BringToFront();
            labelPublisherBook1.Visible = true;
            labelPublisherBook1.BringToFront();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblDescriptionBook1.Visible = false;
            book1Blank.Visible = false;
            labelAuthorBook1.Visible = false;
            labelPagesBook1.Visible = false;
            labelPublishedBook1.Visible = false;
            labelPublisherBook1.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            lblDescriptionBook2.Visible = true;
            book2Blank.Visible = true;
            labelAuthorBook2.Visible = true;
            labelAuthorBook2.BringToFront();
            labelPagesBook2.Visible = true;
            labelPagesBook2.BringToFront();
            labelPublishedBook2.Visible = true;
            labelPublishedBook2.BringToFront();
            labelPublisherBook2.Visible = true;
            labelPublisherBook2.BringToFront();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblDescriptionBook2.Visible = false;
            book2Blank.Visible = false;
            labelAuthorBook2.Visible = false;
            labelPagesBook2.Visible = false;
            labelPublishedBook2.Visible = false;
            labelPublisherBook2.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            lblDescriptionBook3.Visible = true;
            book3Blank.Visible = true;
            labelAuthorBook3.Visible = true;
            labelAuthorBook3.BringToFront();
            labelPagesBook3.Visible = true;
            labelPagesBook3.BringToFront();
            labelPublishedBook3.Visible = true;
            labelPublishedBook3.BringToFront();
            labelPublisherBook3.Visible = true;
            labelPublisherBook3.BringToFront();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            lblDescriptionBook3.Visible = false;
            book3Blank.Visible = false;
            labelAuthorBook3.Visible = false;
            labelPagesBook3.Visible = false;
            labelPublishedBook3.Visible = false;
            labelPublisherBook3.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            lblDescriptionBook4.Visible = true;
            book4Blank.Visible = true;
            labelAuthorBook4.Visible = true;
            labelAuthorBook4.BringToFront();
            labelPagesBook4.Visible = true;
            labelPagesBook4.BringToFront();
            labelPublishedBook4.Visible = true;
            labelPublishedBook4.BringToFront();
            labelPublisherBook4.Visible = true;
            labelPublisherBook4.BringToFront();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            lblDescriptionBook4.Visible = false;
            book4Blank.Visible = false;
            labelAuthorBook4.Visible = false;
            labelPagesBook4.Visible = false;
            labelPublishedBook4.Visible = false;
            labelPublisherBook4.Visible = false;
        }
    }
}
