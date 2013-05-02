using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoopWithArrays
{
    public partial class Form1 : Form
    {
        string[] Students = {
                                    "Suzy",
                                    "Tom",
                                    "Jeff",
                                    "Betty",
                                    "Paul",
                                    "John"
                                };
        int[] Credits = {
                            34,
                            67,
                            22,
                            89,
                            0,
                            21


                        };


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int i = 0;
            while (i < Students.Length)
            {
                lbxStudents.Items.Add(Students[i]);
                i++;
            }


        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbxStudents.SelectedIndex;
            lblStudent.Text = Students[i];
            lblCredits.Text = Credits[i].ToString();

        }
    }
}
