using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Datenbanken_V2
{
    internal class Insert_Person_sql
    {
        public void insert(string Vorname, string Nachname/*,string Arbeitszeit, string mitarbeiter*/)
        {
            string verbindungsstring = "Provider=Microsoft.ACE.OLEDB.12.0;DATA Source=D:/Visual_studio_community/Schule/Datenbank/Datenbank Zeiterfassung.mdb";
            bool offen = true;
            OleDbConnection dBVerbindung = null;
            OleDbCommand cmd;
            OleDbDataReader reader = null;
            try
            {
                string _Vorname = Vorname;
                string _Nachname = Nachname;
                //string _Arbeitszeit = null;
                //string _mitarbeiter = null;

                MessageBox.Show(_Vorname);
                MessageBox.Show(_Nachname);
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                cmd = dBVerbindung.CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_mitarbeiter('Vorname','Nachname') VALUES ("+_Vorname+","+_Nachname+";)";
            

            }

            catch (Exception ausnahme)

            {

                MessageBox.Show("datenbankfehler: " + ausnahme.Message);

            }
            finally
            {

                if (offen == true) dBVerbindung.Close();

            }
           



        }


    }
}
