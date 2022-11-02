using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listdestin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            listemiteur.Items.Add(txtentre.Text);
            txtentre.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(listemiteur .SelectedIndex == -1)
            {
                MessageBox.Show("remplacer un élément vers la liste et selectionnez vous le");
            } 
            else
            { 
               listdestinataire.Items.Add(listemiteur.SelectedItem);
               listemiteur.Items.Remove(listemiteur.SelectedItem);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        { 
            if(listdestinataire.SelectedIndex == -1)
            {
                MessageBox.Show("remplacer un élément vers la liste et selectionnez vous le");
            }
            else
            { 
                listemiteur.Items.Add(listdestinataire.SelectedItem);
                listdestinataire.Items.Remove(listdestinataire.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
