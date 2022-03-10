using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datenbank
{
    internal class SQL : Datenbank
    {
        public void select()
        {
            string verbindungsstring = "Provider=Microsoft.Jet.OLEDB.4.0;DATA Source=D:/Visual_studio_community/Schule/Datenbank/Datenbank Zeiterfassung.mdb";
            bool offen = true;
            OleDbConnection dBVerbindung = null;
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                cmd = dBVerbindung.CreateCommand();
               
                //Befehl SELECT
                cmd.CommandText = "SELECT * FROM tbl_mitarbeiter";
               reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    MessageBox.Show("Name: "+reader.GetString(1));
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
