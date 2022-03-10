using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennenspiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void auto_eins_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void berechnen_Click(object sender, EventArgs e)
        {
            CAuto autoeins = new CAuto(Convert.ToString(auto_eins_text.Text), Convert.ToString(auto_eins_farbe.Text), Convert.ToDouble(auto_eins_geschwindigkeit));
            CAuto autozwei = new CAuto(Convert.ToString(auto_zwei_text.Text), Convert.ToString(auto_zwei_farbe.Text), Convert.ToDouble(auto_zwei_geschwindigkeit));
            label_auto_eins.Text = auto_eins_text.Text;
            label_auto_zwei.Text = auto_zwei_text.Text;

            nullaufhunderteins.Text = Convert.ToString(autoeins.Rennen());
            nullaufhundertzwei.Text = Convert.ToString(autozwei.Rennen());

        }
    }
}
