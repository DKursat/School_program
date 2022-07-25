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
        public void Insert(string Nachname, string Vorname)
        {
            string verbindungsstring = "Provider=Microsoft.ACE.OLEDB.12.0;DATA Source=D:/Visual_studio_community/Schule/Datenbank/Datenbank Zeiterfassung.mdb";
            bool offen = true;
            OleDbConnection dBVerbindung = null;
            OleDbCommand cmd;
            try
            {
                string _Vorname = Vorname;
                string _Nachname = Nachname;
                string _Arbeitszeit = "0";
                string _MitarbeiterID = "0";

                MessageBox.Show(_Vorname);
                MessageBox.Show(_Nachname);
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                cmd = dBVerbindung.CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_mitarbeiter (Nachname,Vorname,`Arbeitszeit gesamt`,MitarbeiterID) " +
                    "VALUES ('" + _Nachname + "','" + _Vorname+"','"+_Arbeitszeit+"','"+_MitarbeiterID+"');";
                cmd.ExecuteNonQuery();
            

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
