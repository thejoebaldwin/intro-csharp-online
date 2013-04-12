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
            lblSpecialOrder.Text = string.Empty;
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
       
        }

        private void UpdateFlavor()
        {
            //declare variables
            string strMessage = string.Empty;
            string strOtherMessage = string.Empty;
            int intScoops = 0;
            //get user input
            Int32.TryParse(txtScoops.Text, out intScoops);



            //logic & calculations
            if (rbChocolate.Checked == true)
            {
                strMessage = " of Chocolate";
                ClearOther();
            }
            else if (rbVanilla.Checked == true)
            {
                strMessage = " of Vanilla";
                ClearOther();
            }
            else if (rbStrawberry.Checked == true)
            {
                strMessage = " of Strawberry";
                ClearOther();
            }
            else if (rbOther.Checked == true)
            {

                gbOther.Visible = true;
                //declare variables
                string strOther = string.Empty;
                //get user input
                strOther = txtOther.Text;
                //logic
                strMessage = "  special order";
                switch (strOther.ToLower())
                {
                    case "coffee":
                     
                        strOtherMessage = " coffee";
                        break;
                    case "bacon":
                    
                        strOtherMessage = " bacon";
                        break;
                    case "pistachio":
                      
                        strOtherMessage = " pistachio";
                        break;
                    case "blue moon":
                      
                        strOtherMessage = " blue moon";
                        break;
                    default:
                        strMessage = "Sorry, we do not carry that flavor";
                        break;
                }



              
             






            }
        
            else
            {
                strMessage = "Please select an Ice Cream Flavor";
            }

            //true && true = true
            //false && true = false
            //true && false = false
            //false && false = false

            lblSpecialOrder.Text = string.Empty;
            lblMessage.Text = string.Empty;

            if (intScoops > 1 && rbOther.Checked == true && strOtherMessage != string.Empty)
            {
                lblSpecialOrder.Text = intScoops.ToString() + " Scoops " + strOtherMessage;
            }
            else if (intScoops > 1 && rbOther.Checked != true)
            {
                lblMessage.Text = intScoops.ToString() + " Scoops " + strMessage;
            }
            else if (intScoops <= 1 && rbOther.Checked == true && strOtherMessage != string.Empty)
            {
                lblSpecialOrder.Text = "1 Scoop " + strOtherMessage;
            }
            else if (intScoops <= 1 && rbOther.Checked != true)
            {
                lblMessage.Text = "1 Scoop " + strMessage;
            }

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

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.Focus();
            txtOther.SelectAll();
            UpdateFlavor();
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }

        private void txtScoops_TextChanged(object sender, EventArgs e)
        {
            UpdateFlavor();
        }
    }
}
