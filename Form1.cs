using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int Q1;

        string _truePassword;
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
            
            if (checkBox2.Checked==true && checkBox3.Checked == false)
            {
                for (int i = 0; i < lenght.Length; i++)
                {
                    if (checkBox1.Checked==false)
                    {
                        Q1 = rand.Next(1, 4);
                        if (Q1 == 1)
                        {
                            lenght[i] = (char)rand.Next(48, 58);
                        }
                        if (Q1 == 2)
                        {
                            lenght[i] = (char)rand.Next(65, 91);
                        }
                        if (Q1 == 3)
                        {
                            lenght[i] = (char)rand.Next(97, 123);
                        }
                    }


                    if (checkBox1.Checked == true)
                    {
                        B:
                        Q1 = rand.Next(1, 4);
                        if (Q1 == 1)
                        {
                            lenght[i] = (char)rand.Next(48, 58);
                        }
                        if (Q1 == 2)
                        {
                            lenght[i] = (char)rand.Next(65, 91);
                        }
                        if (Q1 == 3)
                        {
                            lenght[i] = (char)rand.Next(97, 123);
                        }
                        if (i != 0)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                if (lenght[k] == lenght[i])
                                {
                                    goto B;
                                }
                            }
                        }
                    }
                    textBox1.Text += lenght[i].ToString();
                }
            }


            if (checkBox2.Checked == false&&checkBox3.Checked==false)
            {
                for (int i = 0; i < lenght.Length; i++)
                {

                    if (checkBox1.Checked == false)
                    {
                        lenght[i] = (char)rand.Next(33, 127);
                    }

                    if (checkBox1.Checked == true)
                    {
                    A:
                        lenght[i] = (char)rand.Next(33, 127);
                        if (i != 0)
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
            if (checkBox1.Checked==true&&checkBox3.Checked==true&&checkBox2.Checked==false)
            {
                ohshitherewegoagain:
                _truePassword = null;
                for (int i = 0; i < lenght.Length; i++)
                {
                        PP:
                        lenght[i] = (char)rand.Next(33, 127);
                        if (i != 0)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                if (lenght[k] == lenght[i])
                                {
                                    goto PP;
                                }
                            }
                        }
                        _truePassword += lenght[i].ToString();
                }
                string regexpass = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$";
                if (Regex.IsMatch(_truePassword, regexpass))
                {
                    textBox1.Text = _truePassword;
                }
                else
                {
                    goto ohshitherewegoagain;
                }
            }
            if (checkBox1.Checked == true && checkBox3.Checked == true && checkBox2.Checked == true)
            {
                textBox1.Text = "error";
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
