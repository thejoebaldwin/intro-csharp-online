using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {
            lblBlank.Text = "";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Goodbye!";
        }
    }
}
