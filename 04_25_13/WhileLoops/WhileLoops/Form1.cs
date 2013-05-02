using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            lbxMessage.Items.Clear();
            
            
            string strMessage = string.Empty;
            double dblLimit = 0;
            Double.TryParse(txtLimit.Text, out dblLimit);

            //counter
            //stop condition
            //accumulator
            int counter = 0;
            while (counter < dblLimit)
            {
                //strMessage = strMessage + (counter +1).ToString() + "\n";
                //same as:
                //strMessage += (counter + 1).ToString() + "\n";
                lbxMessage.Items.Add((counter + 1).ToString());
                //counter = counter + 1;
                //same as:
                //counter += 1;
                //same as
                counter++;
            }
            
          
            //lblMessage.Text = strMessage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            lbxMessage.Items.Clear();
        }

        private void lbxMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intSelectedIndex = lbxMessage.SelectedIndex + 1;
            lblMessage.Text = intSelectedIndex.ToString();
        }
    }
}
