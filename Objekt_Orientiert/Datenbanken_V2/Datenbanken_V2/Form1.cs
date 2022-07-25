using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenbanken_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Messagebox_sql messagebox_sql = new Messagebox_sql();
            messagebox_sql.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "datenbank_ZeiterfassungDataSet.tbl_mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
            this.tbl_mitarbeiterTableAdapter.Fill(this.datenbank_ZeiterfassungDataSet.tbl_mitarbeiter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Insert_Person_sql insert_Person_Sql = new Insert_Person_sql();
            insert_Person_Sql.Insert(Convert.ToString(Nachname.Text),Convert.ToString(Vorname.Text));
        }
    }
}
