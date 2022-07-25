using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace Pruefungsvorbereitung
{
    internal class Testbereich
    {
        private readonly string verbindungsstring =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Github/Visual_studio_community/Schule/Pruefungsvorbereitung/Pruefungsvorbereitung/BspDB.mdb";
        protected bool offen = false;

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;  
        public void Datenbankverbindung()
        {
            try
            {
                conn= new OleDbConnection(verbindungsstring);
                conn.Open();
               offen = true;

            }
            catch (Exception excep)
            {
             
                MessageBox.Show(Convert.ToString(excep));
            }
        }

        public void Datenbankverbindungschließen()
        {
            if (offen == true)
            {
                
                conn = new OleDbConnection(verbindungsstring); 
                conn.Close();
                string geschlossen = "Die Verbindung wurde erfolgreich geschlossen!!";
                MessageBox.Show(geschlossen);
                offen = false;
            }

            else
            {
                MessageBox.Show("Bool hat nicht geklappt kontaktiere denn Hersteller der hat es versaut!!!");
            }
            
            
        }

        public void Tbl_Stadt()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select StadtID, Name,PLZ FROM Staedte";
            reader = cmd.ExecuteReader();
            reader.Read();
            ArrayList schwul = new ArrayList();
            while(reader.Read())
            {
             schwul.Add(reader.GetString(1));
            }
           
        }
        public void Tbl_Person() 
        { 
        
        }
        public void Tbl_Wohnort()
        {

        }
        public void Tbl_Alle_einzeln()
        {

        }
        public void Tbl_allinone()
        {

        }

     
    }
}
