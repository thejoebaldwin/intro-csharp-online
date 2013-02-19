using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //**PSEUDOCODE***
            //declare variables
            Double dblWage = 0;
            Double dblHours = 0;
            Double dblSalary = 0;
            //get input from the user
            //dblWage = Convert.ToDouble(txtWage.Text);
            //the next line does the same thing as the line above
            Double.TryParse(txtWage.Text, out dblWage);



            //dblHours = Convert.ToDouble(txtHours.Text);
            //the next line does the same thing as the line above
            Double.TryParse(txtHours.Text, out dblHours);
            //do the calculation
            //salary = wage x hours per week x 52 weeks per year
            dblSalary = dblWage * dblHours * 52;
            //output the results to the user
            lblSalary.Text = dblSalary.ToString();
            txtWage.Focus();
            txtWage.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear out the placeholder text
            lblSalary.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all input and output
            txtHours.Clear();
            txtWage.Clear();
            lblSalary.Text = "";
            //return focus to the top text box
            txtWage.Focus();
        }
    }
}
