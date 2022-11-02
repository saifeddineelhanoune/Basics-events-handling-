using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listville.Items.Add(txtville.Text);
            txtville.Text = "";
            txtville.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            listville.Items.Remove(listville.SelectedItem.ToString());

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listville.SelectedItem.ToString());
        }

        private void btnAffichertt_Click(object sender, EventArgs e)
        {
            foreach (object affiche in listville.SelectedItems)
            {
                MessageBox.Show(affiche.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserer_Click(object sender, EventArgs e)
        {
            int SI = listville.SelectedIndex;
            listville.Items.Remove(listville.SelectedItem);
            listville.Items.Insert(SI, txtville.Text);
        }
    }
    }