using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputMirror
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Clearing out the display label
            lblDisplay.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //take the user input and displaying it on the label
            lblDisplay.Text = txtDisplay.Text;
            //Returning focus to the textbox, and selecting all text
            txtDisplay.Focus();
            txtDisplay.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing out the textbox and the label
            lblDisplay.Text = "";
            txtDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the program
            Application.Exit();
        }
    }
}
