using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] pay1 = { "CASA", "RABAT", "TANGER", "AGDIR", "MARRAKECH", "TAZA", "OUJDA" };
            string[] pay2 = { "TOULOUSE", "PARIS", "MARSEIL", "LILLE", "LYON" };
            string[] pay3 = { "NAPOLI", "MILAN" };
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "MAROC")
            {
                
                comboBox2.Items.AddRange(pay1);
            }
            else
            {
               
                if(comboBox1.SelectedItem.ToString() == "FRANCE")
                {
                    comboBox2.Items.AddRange(pay2);
                }
                else
                {
                
                    comboBox2.Items.AddRange(pay3);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "MAROC";
        }
    }
}
