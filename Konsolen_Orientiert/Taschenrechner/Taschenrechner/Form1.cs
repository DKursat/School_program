using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_Ausgabe.Text = "  ";
        }

     
        private void button_null_Click(object sender, EventArgs e)
        {
            button_null.Text = "0";
            label_Ausgabe.Text = label_Ausgabe.Text + button_null.Text;
        }

        private void button_eins_Click(object sender, EventArgs e)
        {
            button_eins.Text = "1" ;
            label_Ausgabe.Text = label_Ausgabe.Text + button_eins.Text;
        }
        private void button_zwei_Click(object sender, EventArgs e)
        {
            button_zwei.Text = "2";
            label_Ausgabe.Text = label_Ausgabe.Text + button_zwei.Text;
        }

        private void button_drei_Click(object sender, EventArgs e)
        {
            button_drei.Text = "3";
            label_Ausgabe.Text = label_Ausgabe.Text + button_drei.Text;
        }

        private void button_vier_Click(object sender, EventArgs e)
        {
            button_vier.Text = "4";
            label_Ausgabe.Text = label_Ausgabe.Text + button_vier.Text;
        }

            private void button_fünf_Click(object sender, EventArgs e)
        {
            button_fünf.Text = "5";
            label_Ausgabe.Text = label_Ausgabe.Text + button_fünf.Text;
        }

        private void button_sechs_Click(object sender, EventArgs e)
        {
            button_sechs.Text = "6";
            label_Ausgabe.Text = label_Ausgabe.Text + button_sechs.Text;
        }

        private void button_sieben_Click(object sender, EventArgs e)
        {
            button_sieben.Text = "7";
            label_Ausgabe.Text = label_Ausgabe.Text + button_sieben.Text;
        }

        private void button_acht_Click(object sender, EventArgs e)
        {
            button_acht.Text = "8";
            label_Ausgabe.Text = label_Ausgabe.Text + button_acht.Text;
        }

        private void button_neun_Click(object sender, EventArgs e)
        {
            button_neun.Text = "9";
            label_Ausgabe.Text = label_Ausgabe.Text + button_neun.Text;
        }

        private void button_ausgabe_Click(object sender, EventArgs e)
        {

        }

        private void button_addition_Click(object sender, EventArgs e)
        {

        }

        private void button_subtraktion_Click(object sender, EventArgs e)
        {

        }

        private void button_multiplikation_Click(object sender, EventArgs e)
        {

        }

        private void button_divison_Click(object sender, EventArgs e)
        {

        }

        private void label_Ausgabe_Click(object sender, EventArgs e)
        {

        }
    }
}
