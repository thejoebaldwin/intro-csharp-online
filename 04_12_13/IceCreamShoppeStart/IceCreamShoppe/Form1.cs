using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IceCreamShoppe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        private void chkChocolate_CheckedChanged(object sender, EventArgs e)
        {
            chkVanilla.Checked = false;
            chkStrawberry.Checked = false;
        }

        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            chkChocolate.Checked = false;
            chkStrawberry.Checked = false;
        }

        private void chkStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            chkChocolate.Checked = false;
            chkVanilla.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }


        private void ClearOther()
        {
            gbOther.Visible = false;
            rbPistachio.Checked = false;
            rbBacon.Checked = false;
            rbCoffee.Checked = false;
        }

        private void UpdateFlavor()
        {
            //declare variables
            string strMessage = string.Empty;
            //get user input
            //logic & calculations
            if (rbChocolate.Checked == true)
            {
                strMessage = "1 Scoop of Chocolate";
                ClearOther();
            }
            else if (rbVanilla.Checked == true)
            {
                strMessage = "1 Scoop of Vanilla";
                ClearOther();
            }
            else if (rbStrawberry.Checked == true)
            {
                strMessage = "1 Scoop of Strawberry";
                ClearOther();
            }
            else if (rbOther.Checked == true)
            {
                gbOther.Visible = true;
                if (rbPistachio.Checked == true)
                {
                    strMessage = "1 scoop of Pistachio";
                }
                else if (rbBacon.Checked == true)
                {
                    strMessage = "1 scoop of bacon";
                }
                else if (rbCoffee.Checked == true)
                {
                    strMessage = "1 scoop of coffee";
                }
                else
                {
                    strMessage = "Please select a flavor from the list of Other Flavors";
                }

               
            }
        
            else
            {
                strMessage = "Please select an Ice Cream Flavor";
            }

            //output to user
            lblMessage.Text = strMessage;

        }

        private void rbChocolate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void rbVanilla_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void rbStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void rbPistachio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void rbBacon_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }
    }
}
