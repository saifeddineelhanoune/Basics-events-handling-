using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATRICE
{
    public partial class Form1 : Form
    {
        int a, b;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "9";
            }
            else
            {
                txtecran.AppendText("9");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "6";
            }
            else
            {
                txtecran.AppendText("6");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "3";
            }
            else
            {
                txtecran.AppendText("3");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int  c = 0;
            b = int.Parse(txtecran);
            if (op == '+')
            { 
                c = a + b;
            }
            if (op == '-')
            { 
                c = a - b;
            }
            if (op == '*')
            { 
                c = a * b;
            }
            txtecran.Text = c.ToString();
            if (op == '/')
            {
                if (b == 0)
                {
                    MessageBox.Show("impossible");
                }
                else
                {
                    c = a / b;
                    txtecran.Text = c.ToString();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "1";
            }
            else
            {
                txtecran.AppendText("1");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "2";
            }
            else
            {
                txtecran.AppendText("2");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "7";
            }
            else
            {
                txtecran.AppendText("7");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "4";
            }
            else
            {
                txtecran.AppendText("7");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "5";
            }
            else
            {
                txtecran.AppendText("5");
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "8";
            }
            else
            {
                txtecran.AppendText("8");
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtecran.Text);
            op = '+';
            txtecran.Text = op.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtecran.Text);
            op = '/';
            txtecran.Text = op.ToString();
        }

        private void btnmoin_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtecran.Text);
            op = '-';
            txtecran.Text = op.ToString();
        }

        private void btnmultip_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtecran.Text);
            op = '*';
            txtecran.Text = op.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtecran.Text == "+") || (txtecran.Text == "-") || (txtecran.Text == "*") || (txtecran.Text == "/"))
            {
                txtecran.Text = "0";
            }
            else
            {
                txtecran.AppendText("0");
            }
        }
    }
}
