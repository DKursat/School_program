using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datenbanken_V2
{
    internal class Datenbank
    {
        public void Datenbankverbindung()
        {
            string verbindungsstring = "Provider=Microsoft.Jet.OLEDB.4.0;DATA Source=D:/Visual_studio_community/Schule/Datenbank/Datenbank Zeiterfassung.mdb";
            bool offen = true;
            OleDbConnection dBVerbindung = null;
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();

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
