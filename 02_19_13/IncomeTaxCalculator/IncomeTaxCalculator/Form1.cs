using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IncomeTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear out placeholders
            lblIncomeTax.Text = "";
            lblNetSalary.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all input and output
            txtSalary.Text = "";
            lblIncomeTax.Text = "";
            lblNetSalary.Text = "";
            txtSalary.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables
            Double dblSalary = 0;
            Double dblIncomeTax = 0;
            Double dblNetSalary = 0;
            //get input from the user
            Double.TryParse(txtSalary.Text, out dblSalary);
            //do calculations
            //  Income Tax Owed = Salary x 6.5%
            dblIncomeTax = dblSalary * 0.065;
            //  Net Salary = Salary - Income Tax Owed
            dblNetSalary = dblSalary - dblIncomeTax;
            //output results to the user
            //display values formatted as currency
            lblIncomeTax.Text = dblIncomeTax.ToString("c");
            lblNetSalary.Text = dblNetSalary.ToString("c");
            //return focus to the textbox
            txtSalary.Focus();
            txtSalary.SelectAll();
        }
    }
}
