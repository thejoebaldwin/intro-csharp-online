using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BurgerCity
{
    public partial class Form1 : Form
    {
        const double LETTUCE_COST = 1.0;
        const double CHEESE_COST = 0.50;
        const double ONION_COST = 0.25;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        private void UpdatePrice()
        {
            //declare variables
            double dblTotal = 5;
            //bool blnLettuce = false;
            //bool blnCheese = false;
            //get user input
            //blnLettuce = chkLettuce.Checked;
            //blnCheese = chkCheese.Checked;
            //do calculations
            //  what toppings to add to total?
            if (chkLettuce.Checked)
            {
                dblTotal = dblTotal + LETTUCE_COST;
            }

            if (chkCheese.Checked)
            {
                dblTotal = dblTotal + CHEESE_COST;
            }

            if (chkOnions.Checked)
            {
                dblTotal = dblTotal + ONION_COST;
            }
            //output result to user
            lblTotal.Text = dblTotal.ToString("c");

        }
        
        
        
     
        private void chkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
        }
    }
}
