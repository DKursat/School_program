using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datenbanken_V2
{
    internal class Messagebox_sql
    {
        public void Select()
        {
            string verbindungsstring = "Provider=Microsoft.ACE.OLEDB.12.0;DATA Source=D:/Visual_studio_community/Schule/Datenbank/Datenbank Zeiterfassung.mdb";
            bool offen = true;
            OleDbConnection dBVerbindung = null;
            OleDbCommand cmd;
            OleDbDataReader reader = null;
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                cmd = dBVerbindung.CreateCommand();

                //Befehl SELECT
                cmd.CommandText = "SELECT * FROM tbl_mitarbeiter";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Name: " + reader.GetString(0));
                }

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
