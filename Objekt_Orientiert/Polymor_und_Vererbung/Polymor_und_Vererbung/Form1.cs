using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymor_und_Vererbung
{
    public partial class Form1 : Form
    {
       private CPrivat_Kunde kunde1;
        private CFirmen_Kunde kunde2, kunde3;
        private CKunde[] kunden = new CKunde[3];
        private String LF ="\n";

        public Form1()
        {
            InitializeComponent();
            kunde1 = new CPrivat_Kunde("Herr", "Krause", "Leipzig");
            kunde1.Stammkunde = false;
            kunde2 = new CFirmen_Kunde("Frau", "Müller", "Master Soft Gmbh");
            kunde2.Stammkunde = true;
            kunde3 = new CFirmen_Kunde("Herr", "Maus", "Manfreds Internet AG");
            kunde3.Stammkunde = false;

            kunden[0] = kunde1;
            kunden[1] = kunde2;
            kunden[2] = kunde3;

            textBox1.Text = "100";
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal brutto = Convert.ToDecimal(textBox1.Text);
            richTextBox1.Text = String.Empty;
            foreach (CKunde ku in kunden)
            {
                ku.AddGuthaben(brutto);
                richTextBox1.Text = richTextBox1.Text + LF + ku.GetAdresse() + LF + ku.Guthaben.ToString("C") + LF;

            }
            MessageBox.Show(kunde1.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal brutto = Convert.ToDecimal(textBox1.Text);
            richTextBox1.Text = String.Empty;
            for (int i = 0; i < kunden.Length; i++)
            {
                kunden[i].AddGuthaben(brutto);
                richTextBox1.Text = richTextBox1.Text + LF + kunden[i].GetAdresse()+ LF + kunden[i].Guthaben.ToString("C") + LF;

            }
            MessageBox.Show(kunde1.ToString());
        }
    }
}
