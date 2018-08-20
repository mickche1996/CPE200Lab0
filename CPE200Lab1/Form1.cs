using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {

        string text,text2,operater,result;
        int x1, x2,x3,check;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {   
            if(check < 5) {
            text += 1;
            lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 2;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }
    

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = text.Length.ToString(); ;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 3;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 4;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (check < 9)
            {
                text += 5;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 6;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 7;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 8;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operater = "-";
            text2 = text;
            //text += "+";
            lblDisplay.Text = text;
            text = null;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operater = "*";
            text2 = text;
            //text += "+";
            lblDisplay.Text = text;
            text = null;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operater = "/";
            text2 = text;
            //text += "+";
            lblDisplay.Text = text;
            text = null;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 9;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (check < 8)
            {
                text += 0;
                lblDisplay.Text = text;
                check = text.Length;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            text = null;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(operater == "+")
            {
                x1= int.Parse(text);
                x2= int.Parse(text2);
                x3= x2 + x1;
                result = x3.ToString();
                lblDisplay.Text=result;
            }
            if (operater == "-")
            {
                x1 = int.Parse(text);
                x2 = int.Parse(text2);
                x3 = x2 - x1;
                result = x3.ToString();
                lblDisplay.Text = result;
            }
            if (operater == "*")
            {
                x1 = int.Parse(text);
                x2 = int.Parse(text2);
                x3 = x2 * x1;
                result = x3.ToString();
                lblDisplay.Text = result;
            }
            if (operater == "/")
            {
                x1 = int.Parse(text);
                x2 = int.Parse(text2);
                x3 = x2 / x1;
                result = x3.ToString();
                lblDisplay.Text = result;
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operater = "+";
            text2 = text ;
            //text += "+";
            lblDisplay.Text = text;
            text = null;}
    }
}
