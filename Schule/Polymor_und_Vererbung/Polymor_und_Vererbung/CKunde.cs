using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymor_und_Vererbung
{
    internal class CKunde
    {
        //Variable
        private string anrede;
        private string name;
        private bool stammKu;
        protected decimal guthaben = 0; //Feld ist in Subklassen sichtbar!

        //Konstruktor
        public CKunde(string aAnrede, string nName)
        {
            anrede = aAnrede;
            name = nName;
        }
        //Eigenschaften

        public string Anrede
        {
            get { return anrede; }
            set { anrede = value; }
        }
        public string Nachname
        {
            get { return name; }
            set { name = value; }
        }
        public bool Stammkunde
        {
            get { return stammKu; }
            set { stammKu = value; }
        }
        public decimal Guthaben //ReadOnly
        {
            get { return guthaben; }
        }

        //Methode
        public virtual string GetAdresse()//virtuelle Methode
        {
            string s = anrede + "" + name;
            return s;
        }
        public virtual void AddGuthaben(decimal betrag) //virtuelle Methode
        {
            if (stammKu) guthaben += betrag;
        }
        public void Textbox()
        {
            MessageBox.Show("Hallo Kunde");
        }


    }
}
