using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuffetBill
{
    public partial class Form1 : Form
    {

        const double GUEST_COST = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "";

            lblCost.Text = GUEST_COST.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            lblTotal.Text = "";
            txtQuantity.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare Variables
            Double dblQuantity = 0;
            Double dblTotal = 0;
            //get the input from the user
            Double.TryParse(txtQuantity.Text, out dblQuantity);
            //calculate
            //  number of guests x GUEST_COST
         
            dblTotal = dblQuantity * GUEST_COST;
    
            //output to the user
            lblTotal.Text = dblTotal.ToString("c");
            //return focus
            txtQuantity.Focus();
            txtQuantity.SelectAll();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }
    }
}
