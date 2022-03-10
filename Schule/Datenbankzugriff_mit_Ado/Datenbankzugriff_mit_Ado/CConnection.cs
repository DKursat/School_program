using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datenbankzugriff_mit_Ado
{
    internal class CConnection
    {
        public void Verbindung()
        {
            string verbindungsstring = "Provider=Microsoft.Jet.OLEDB.4.0;DATA Source=D:/EA19B/Programmieren/Schule/simeth/Programmieren Datenbank/Datenbank Zeiterfassung.mdb";
            System.Data.OleDb.OleDbConnection dBVerbindung = null;
            System.Data.OleDb.OleDbCommand befehl = null;
            System.Data.OleDb.OleDbDataReader datenleser = null;
            bool offen = false;
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;

                befehl = dBVerbindung.CreateCommand();
                befehl.CommandText = "SELECT * FROM tbl_mitarbeiter";

                datenleser = befehl.ExecuteReader();
                while (datenleser.Read())
                {
                    MessageBox.Show(datenleser.GetString(1));

                }

            }
            catch (Exception ausnahme)
            {
                MessageBox.Show("Datenbankfehler: " + ausnahme.Message);
            }
            finally
            {
                if (offen == true) dBVerbindung.Close();
            }

        }

    }
}
