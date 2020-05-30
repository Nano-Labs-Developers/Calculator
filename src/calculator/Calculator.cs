using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        #region Global vars
        string Theam = "Default"; // Default is white

        double FirstNumber;
        double SecondNumber;
        string Operation;
        #endregion

        public calculator()
        {
            InitializeComponent();
        }

        #region Numbers

        #region N1
        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null )
            {
                textBox1.Text = "1";
                textBox2.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                textBox2.Text = textBox2.Text + "1";
            }
        }
        #endregion

        #region N2
        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                textBox2.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                textBox2.Text = textBox2.Text + "2";
            }
        }
        #endregion

        #region N3
        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                textBox2.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                textBox2.Text = textBox2.Text + "3";
            }
        }
        #endregion

        #region N4
        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                textBox2.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                textBox2.Text = textBox2.Text + "4";
            }
        }
        #endregion

        #region N5
        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                textBox2.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                textBox2.Text = textBox2.Text + "5";
            }
        }
        #endregion

        #region N6
        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                textBox2.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                textBox2.Text = textBox2.Text + "6";
            }
        }
        #endregion

        #region N7
        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                textBox2.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                textBox2.Text = textBox2.Text + "7";
            }
        }
        #endregion

        #region N8
        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                textBox2.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                textBox2.Text = textBox2.Text + "8";
            }
        }
        #endregion

        #region N9
        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                textBox2.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                textBox2.Text = textBox2.Text + "9";
            }
        }
        #endregion

        #region N0
        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                textBox2.Text = textBox2.Text + "0";
            }
        }
        #endregion

        #endregion

        #region Clear C
        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            textBox2.Text = "";
        }
        #endregion

        #region Clear CE
        private void btnce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }
        #endregion

        #region Dot
        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        #endregion

        #region SUM Btn
        private void btnsum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }
        #endregion

        #region - Btn
        private void btnunsum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = textBox2.Text + "-";
            Operation = "-";            
        }
        #endregion

        #region * Btn
        private void btnmulti_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = textBox2.Text + "*";
            Operation = "*";            
        }
        #endregion

        #region / Btn
        private void button6_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = textBox2.Text + "/";
            Operation = "/";            
        }
        #endregion

        #region Equal
        private void btnequal_Click(object sender, EventArgs e)
        {
            SecondNumber = double.Parse(textBox1.Text);

            switch (Operation)
            {
                case "+":
                    textBox1.Text = (FirstNumber + SecondNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (FirstNumber - SecondNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (FirstNumber * SecondNumber).ToString();
                    break;
                case "/":
                    if (SecondNumber != 0)
                    {
                        textBox1.Text = (FirstNumber / SecondNumber).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Can't devide by zero";
                        textBox2.Text = "";
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Backspace
        private void button1_Click(object sender, EventArgs e)
        {
            string txtbox = textBox1.Text;
            string txtbox2 = textBox2.Text;
            string res = "";

            if (textBox1.Text.Length == 1)
            {

                if (FirstNumber == 0)
                {
                    textBox1.Text = "0";
                    textBox2.Text = "";
                }
            }
            else
            {
                for (int i = 0; i < txtbox.Length - 1; i++)
                {
                    res = res + txtbox[i];
                    
                }

                textBox1.Text = res;
            }       
        }
        #endregion

        #region Movement Header
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void calculator_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
 
        #region Theam

        private void btntheam_Click(object sender, EventArgs e)
        {
            if (Theam != "White")
            {
                Theam = "White";
                btntheam.Text = "Dark";
                btntheam.BackColor = Color.FromArgb(31, 31, 31);
                btntheam.ForeColor = Color.White;

                #region Side Menu

                sidemenu.BackgroundImage = Properties.Resources.open_menu;

                #endregion

                #region Main Lable

                main_name.ForeColor = Color.Black;

                #endregion

                #region panel

                backpanel.BackColor = Color.Silver;

                #endregion

                #region Text Box

                textBox1.BackColor = Color.Silver;
                textBox1.ForeColor = Color.Black;

                textBox2.BackColor = Color.Silver;
                textBox2.ForeColor = Color.Black;

                #endregion

                #region Button

                btnclear.BackColor = Color.FromArgb(140, 140, 140);
                btnclear.ForeColor = Color.Black;

                btnce.BackColor = Color.FromArgb(140, 140, 140);
                btnce.ForeColor = Color.Black;

                btnbackspace.BackColor = Color.FromArgb(140, 140, 140);
                btnbackspace.BackgroundImage = Properties.Resources.backspace_black;

                btndivied.BackColor = Color.FromArgb(140, 140, 140);
                btndivied.BackgroundImage = Properties.Resources.divide_black;

                btnmulti.BackColor = Color.FromArgb(140, 140, 140);
                btnmulti.ForeColor = Color.Black;

                btnunsum.BackColor = Color.FromArgb(140, 140, 140);
                btnunsum.ForeColor = Color.Black;

                btnsum.BackColor = Color.FromArgb(140, 140, 140);
                btnsum.ForeColor = Color.Black;

                btnequal.BackColor = Color.FromArgb(140, 140, 140);
                btnequal.ForeColor = Color.Black;

                plusandminess.BackColor = Color.FromArgb(140, 140, 140);
                plusandminess.ForeColor = Color.Black;

                btndot.BackColor = Color.FromArgb(140, 140, 140);
                btndot.ForeColor = Color.Black;

                #endregion

                #region Numbers
                n0.BackColor = Color.FromArgb(140, 140, 140);
                n1.BackColor = Color.FromArgb(140, 140, 140);
                n2.BackColor = Color.FromArgb(140, 140, 140);
                n3.BackColor = Color.FromArgb(140, 140, 140);
                n4.BackColor = Color.FromArgb(140, 140, 140);
                n5.BackColor = Color.FromArgb(140, 140, 140);
                n6.BackColor = Color.FromArgb(140, 140, 140);
                n7.BackColor = Color.FromArgb(140, 140, 140);
                n8.BackColor = Color.FromArgb(140, 140, 140);
                n9.BackColor = Color.FromArgb(140, 140, 140);

                n0.ForeColor = Color.Black;
                n1.ForeColor = Color.Black;
                n2.ForeColor = Color.Black;
                n3.ForeColor = Color.Black;
                n4.ForeColor = Color.Black;
                n5.ForeColor = Color.Black;
                n6.ForeColor = Color.Black;
                n7.ForeColor = Color.Black;
                n8.ForeColor = Color.Black;
                n9.ForeColor = Color.Black;
                #endregion

            }
            else if (Theam != "Dark") 
            {
                Theam = "Dark";
                btntheam.Text = "Light";
                btntheam.BackColor = Color.White;
                btntheam.ForeColor = Color.FromArgb(31, 31, 31);

                #region Side Menu

                sidemenu.BackgroundImage = Properties.Resources.menu;

                #endregion

                #region Main Lable

                main_name.ForeColor = Color.White;

                #endregion

                #region panel

                backpanel.BackColor = Color.FromArgb(31, 31, 31);

                #endregion

                #region Text Box

                textBox1.BackColor = Color.FromArgb(31, 31, 31);
                textBox1.ForeColor = Color.White;

                textBox2.BackColor = Color.FromArgb(31, 31, 31);
                textBox2.ForeColor = Color.White;

                #endregion

                #region Button

                btnclear.BackColor = Color.FromArgb(18, 18, 18);
                btnclear.ForeColor = Color.White;

                btnce.BackColor = Color.FromArgb(18, 18, 18);
                btnce.ForeColor = Color.White;

                btnbackspace.BackColor = Color.FromArgb(18, 18, 18);
                btnbackspace.BackgroundImage = Properties.Resources.backspace_white1;

                btndivied.BackColor = Color.FromArgb(18, 18, 18);
                btndivied.BackgroundImage = Properties.Resources.divide_white;

                btnmulti.BackColor = Color.FromArgb(18, 18, 18);
                btnmulti.ForeColor = Color.White;

                btnunsum.BackColor = Color.FromArgb(18, 18, 18);
                btnunsum.ForeColor = Color.White;

                btnsum.BackColor = Color.FromArgb(18, 18, 18);
                btnsum.ForeColor = Color.White;

                btnequal.BackColor = Color.FromArgb(18, 18, 18);
                btnequal.ForeColor = Color.White;

                plusandminess.BackColor = Color.FromArgb(18, 18, 18);
                plusandminess.ForeColor = Color.White;

                btndot.BackColor = Color.FromArgb(18, 18, 18);
                btndot.ForeColor = Color.White;

                #endregion

                #region Numbers
                n0.BackColor = Color.Black;
                n1.BackColor = Color.Black;
                n2.BackColor = Color.Black;
                n3.BackColor = Color.Black;
                n4.BackColor = Color.Black;
                n5.BackColor = Color.Black;
                n6.BackColor = Color.Black;
                n7.BackColor = Color.Black;
                n8.BackColor = Color.Black;
                n9.BackColor = Color.Black;

                n0.ForeColor = Color.White;
                n1.ForeColor = Color.White;
                n2.ForeColor = Color.White;
                n3.ForeColor = Color.White;
                n4.ForeColor = Color.White;
                n5.ForeColor = Color.White;
                n6.ForeColor = Color.White;
                n7.ForeColor = Color.White;
                n8.ForeColor = Color.White;
                n9.ForeColor = Color.White;
                #endregion
            }
        }

        #endregion
    }
}
