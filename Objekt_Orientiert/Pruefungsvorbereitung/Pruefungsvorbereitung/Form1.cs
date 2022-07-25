using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruefungsvorbereitung
{
    public partial class Form1 : Form
    {
        Testbereich testbereich = new Testbereich();
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
             private readonly string verbindungsstring =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Github/Visual_studio_community/Schule/Pruefungsvorbereitung/Pruefungsvorbereitung/BspDB.mdb";
        protected bool offen = false;

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        conn = new OleDbConnection(verbindungsstring);
        conn.Open();
                offen = true;

       
        }

    }

        private void button9_Click(object sender, EventArgs e)
        {
            testbereich.Datenbankverbindung();

            string success = "Die Verbindung wurde erfolgreich hergestellt!!";
            MessageBox.Show(success);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            testbereich.Datenbankverbindungschließen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testbereich.Tbl_Stadt();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
