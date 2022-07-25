using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymor_und_Vererbung
{
    internal class CPrivat_Kunde :CKunde 
    {  //Variable
        private string wohnOrt;
        
        //Konstruktor
        public CPrivat_Kunde(string anrede, string name, string ort) : base(anrede, name)
        {
            wohnOrt = ort;
        }
        //Eigenschaften

        //Methode
        public override string GetAdresse()
        {
            const char LF = (char)10; //Zeilenvorschub
            return (base.GetAdresse() + LF + wohnOrt);
        }
        public override void AddGuthaben(decimal geld)
        {
            //Zugriff auf protected-Variable in Basisklaase:
            guthaben += 0.05M * geld;
        }

        new public void Textbox()
        {
            MessageBox.Show("Hallo Privatkunde");   
        }
    }
}
