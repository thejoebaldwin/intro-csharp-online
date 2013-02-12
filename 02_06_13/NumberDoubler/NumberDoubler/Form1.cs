using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberDoubler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            string strHello = "Hello World";

             lblMessage.Text = strHello;

             string strNumber = "56";
            //Numbers 1,2,3,4,5 23.4, 67.3

            //Whole Numbers aka Integers 1,2,3,4,5 also -1,-2,-3
            //Decimal Numbers aka Doubles 1.1,1.2, -1.1, -56.7
            //Strings aka text "hello" "betty" "tom"
            //Boolean - True/False
            

             int intNumber = Convert.ToInt32(txtNumber.Text);
             int intTotal = intNumber * 2;
             


             lblMessage.Text = intTotal.ToString();


            //containers are called variables
            //variables can have "Types" which contain different kinds of values
        }

      
    }
}
