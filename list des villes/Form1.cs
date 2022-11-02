using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_des_villes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            listVilles.Items.Add(txtVilles.Text);
            txtVilles.Text = "";
            txtVilles.Focus();
        }

        private void btnRemplir_Click(object sender, EventArgs e)
        {
            string[] t = new string[] { "casa", "agadir", "tanger", "tetouane", "oujda", "taza", "rabat", "laayoun", "berkane", "fes", "marrakech" };
            listVilles.Items.AddRange(t);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
