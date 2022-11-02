using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les_4_operations_de_2_valeur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomme_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = a + b;
            txtResultat.Text = c.ToString();     
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = a - b;
            txtResultat.Text = c.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            if (b == 0)
            {
                MessageBox.Show("Impossible");
            }
            else
            {
                c = a / b;
                txtResultat.Text = c.ToString();
            }
        }

        private void btnMultiplucation_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = a * b;
            txtResultat.Text = c.ToString();
        }
    }
}
