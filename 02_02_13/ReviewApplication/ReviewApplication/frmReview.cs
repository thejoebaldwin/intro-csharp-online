using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReviewApplication
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the greeting label to hello there
            //  clear out the other labels
            lblGreeting.Text = "Hello There";
            lblResponse.Text = "";
            lblGoodbye.Text = "";
        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            //set the response label to hi, how are you
            lblResponse.Text = "Hi, how are you?";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            //set the good bye label to fine thanks, goodbye
            lblGoodbye.Text = "Fine thanks, Goodbye";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all the labels
            lblGoodbye.Text = "";
            lblGreeting.Text = "";
            lblResponse.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }
    }
}
