using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prf_Datenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_DB_Beispiel_BuchDataSet.Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundenTableAdapter.Fill(this._DB_Beispiel_BuchDataSet.Kunden);

        }
    }
}
