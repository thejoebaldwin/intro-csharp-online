using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //declare variables
            int intQuantity = 0;
            int intTotal = 0;
            //get user input
            Int32.TryParse(textBox1.Text, out intQuantity);
            //do calculations
            intTotal = intQuantity * 5;
            //output to the user
            lblTotal.Text = intTotal.ToString("c");



        }
    }
}
