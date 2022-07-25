using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Prf_Datenbank
{
    internal class Datenbank
    {
        string connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:/Visual_studio_community/Schule/Prf_Datenbank/DB-Beispiel-Buch.mdb";

        public void Datenbankanbindung()
        {
            OleDbConnection conn = new OleDbConnection(connection);
            conn.Open();
            MessageBox.Show("Datenbank ist Verbunden");

        }
        public void Datenbankverbindungentfernen()
        {
            OleDbConnection conn = new OleDbConnection(connection);
            conn.Close();
            MessageBox.Show("Datenbank ist nicht mehr Verbunden");
        }
        public void Message()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader = null;
            cmd.CommandText = "Select * From Kunden";
           cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            MessageBox.Show(Convert.ToString(reader));
           
        }

    }
}
