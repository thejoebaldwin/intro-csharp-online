using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieTickets
{
    public partial class frmMovieTickets : Form
    {
        //Constant values used for calculations
        const double ADULT_COST = 15;
        const double KID_COST = 5;


        public frmMovieTickets()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all input and output
            //   and return focus
            txtAdultQuantity.Clear();
            txtKidQuantity.Clear();
            lblTotal.Text = String.Empty;
            txtAdultQuantity.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear out total placeholder text
            lblTotal.Text = string.Empty;
            //populate pricing display from constants
            lblAdultCost.Text = ADULT_COST.ToString("c");
            lblKidCost.Text = KID_COST.ToString("c");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            Double dblAdultQuantity = 0;
            Double dblKidQuantity = 0;
            Double dblAdultCost = 0;
            Double dblKidCost = 0;
            Double dblTotal = 0;
            //get user input
            Double.TryParse(txtAdultQuantity.Text, out dblAdultQuantity);
            Double.TryParse(txtKidQuantity.Text, out dblKidQuantity);
            //do calculations
            //  adult cost = # of adults x ADULT_COST
            dblAdultCost = dblAdultQuantity * ADULT_COST;
            //  kid cost = # of kids x KID_COST
            dblKidCost = dblKidQuantity * KID_COST;
            //  total = adult cost + kid cost
            dblTotal = dblAdultCost + dblKidCost;
            //output results to user
            lblTotal.Text = dblTotal.ToString("c");
            //return focus to first textbox
            txtAdultQuantity.Focus();
            txtAdultQuantity.SelectAll();

        }

        private void txtAdultQuantity_TextChanged(object sender, EventArgs e)
        {
            //clear out results on user entry
            lblTotal.Text = string.Empty;
        }

        private void txtKidQuantity_TextChanged(object sender, EventArgs e)
        {
            //clear out results on user entry
            lblTotal.Text = string.Empty;
        }
    }
}
