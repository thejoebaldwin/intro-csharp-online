using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets the startup label on form load
            lblStartup.Text = "This text is set on startup";
            lblButtonClick.Text = "";
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //Setting the button label text on a button click
            lblButtonClick.Text = "This text is set up button click";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing out both labels
            lblButtonClick.Text = "";
            lblStartup.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }
    }
}
