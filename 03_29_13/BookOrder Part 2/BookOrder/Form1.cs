using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookOrder
{
    public partial class Form1 : Form
    {
        const double BOOK_PRICE = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTotal.Text = string.Empty;
            lblError.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variables
            int intQuantity = 0;
            double dblDiscount = 0;
            double dblSubtotal = 0;
            double dblTotal = 0;
            string strFirstName = string.Empty;
            string strLastName = string.Empty;
            string strMessage = string.Empty;
            //get input from user
            bool blnSuccess = Int32.TryParse(txtQuantity.Text, out intQuantity);
            strFirstName = txtFirstName.Text;
            strLastName = txtLastName.Text;

            //logic!
            if (blnSuccess == false)
            {
             //output error message to the user
                lblError.Text = "Please enter a number for # of books";
            }


            //   quantity < 5, discount = 0%
            if (intQuantity < 5)
            {
                dblDiscount = 0;
            }
            //   quantity between 5 and 10, discount = 10%
            else if (intQuantity <= 10)
            {
                dblDiscount = 0.10;
            }
            //   quanitity > 10, discount = 15%
            else 
            {
                dblDiscount = 0.15;
            }
            //   subtotal = quantity * BOOK_PRICE 
            dblSubtotal = intQuantity * BOOK_PRICE;
            //   total = subtotal - (subtotal * discount)
            dblTotal = dblSubtotal - dblSubtotal * dblDiscount;
            //output values to user
            lblDiscount.Text = dblDiscount.ToString("p");
            lblSubtotal.Text = dblSubtotal.ToString("c");
            lblTotal.Text = dblTotal.ToString("c");

            strFirstName = strFirstName.ToUpper();
            strLastName = strLastName.ToUpper();

            //remove trailing and leading spaces from first name
            strFirstName = strFirstName.Trim();
            strLastName = strLastName.Trim();

            //remove trailing spaces
            //strFirstName = strFirstName.TrimEnd();
            //strLastName = strLastName.TrimEnd();



            strMessage = strFirstName + " " + strLastName + " owes " + dblTotal.ToString("c");
            strMessage = strMessage.ToUpper();


            lblMessage.Text = strMessage;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            lblDiscount.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTotal.Text = string.Empty;
            lblError.Text = string.Empty;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
