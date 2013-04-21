using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharedPassword
{
    public partial class Form1 : Form
    {
        const string PASSWORD_ONE = "secret";
        const string PASSWORD_TWO = "test1234";
        const string PASSWORD_THREE = "guess";
        const string PASSWORD_FOUR = "birthday";


        const string SUPER_SECRET = "C# is the best";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSecret.Text = string.Empty;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            //get user input
            string strUserPassword1 = txtPassword1.Text.Trim();
            //string strUserPassword2 = txtPassword2.Text.Trim();
            //logic
            if (strUserPassword1 == PASSWORD_ONE
                || strUserPassword1 == PASSWORD_TWO
                || strUserPassword1 == PASSWORD_THREE
                || strUserPassword1 == PASSWORD_FOUR)
            {
                lblSecret.Text = SUPER_SECRET;
            }
            else
            {
                lblSecret.Text = "You have entered an incorrect password";
            }
            //output to user
            txtPassword1.Focus();
            txtPassword1.SelectAll();
        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            lblSecret.Text = string.Empty;
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            lblSecret.Text = string.Empty;
        }
    }
}
