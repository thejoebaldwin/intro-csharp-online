using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecretNumber
{
    public partial class Form1 : Form
    {
        const int SECRET_NUMBER = 67;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //declare variables
            int intGuess = 0;
            //get the user input
            Int32.TryParse(txtGuess.Text, out intGuess);
         
            //output the result to the user

            //not needed because clear on text changed
            //lblMessage.Text = string.Empty;

            //= assignment operator
            //+,-,/,*,% arithmetic operators
            //Comparison operators:
            // == equality operator
            // != inequality operator (<> in visual basic)
            // <, <= less than operator , less than or equal to
            // >, >= greater than operator, greater than or equal to
            // ( 5 < 6) true
            // (5 > 6) false
            // (5 <= 6) true
            // (5 >= 6) false

            //do logic
            //  Test if input equals our secret number (SECRET_NUMBER)
            if (intGuess == SECRET_NUMBER)
            {
                //execute this code here if true
                lblMessage.Text = "You Guessed the correct number!";
            }
            else
            {
                //execute this code here if false
                lblMessage.Text = "You did not guess the correct number!";
            }

            // 5 != 6 This is True
            //this is replace by the above else statement
            //if (intGuess != SECRET_NUMBER)
            //{
             
            //}

            txtGuess.Focus();
            txtGuess.SelectAll();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }
    }
}
