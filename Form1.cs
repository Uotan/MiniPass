﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Random rand2 = new Random();
        about F = new about();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int L = Convert.ToInt16(numericUpDown1.Value.ToString());
            char[] lenght = new char[L];

            for (int i = 0; i < lenght.Length; i++)
            {
                
                if (checkBox1.Checked == false)
                {
                    lenght[i] = (char)rand.Next(33, 127);
                }

                if (checkBox1.Checked==true)
                {
                    A:
                    lenght[i] = (char)rand.Next(33, 127);
                    if (i!=0)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (lenght[k] == lenght[i])
                            {
                                goto A;
                            }
                        }
                    }
                }
                textBox1.Text += lenght[i].ToString();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)textBox1.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F.ShowDialog();
        }
    }
}
