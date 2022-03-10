using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymor_und_Vererbung
{
    internal class CFirmen_Kunde:CKunde 
    {
        //Variable
        private string firma;
        private const float mwst = 0.19F;//Mehrwertsteuer
        //Konstruktor
        public CFirmen_Kunde(string anrede, string name, string frm) : base(anrede, name)
        {
            firma = frm;
        }
        //Eigenschaften
        //Methode
        public override string GetAdresse()
        {
            const char LF = (char)10; //Zeilenvorschub
            return (base.GetAdresse() + LF + firma);
        }
        public override void AddGuthaben(decimal brutto)
        {
            decimal netto = brutto / Convert.ToDecimal(1 + mwst);
            base.AddGuthaben(netto*0.01M);
        }
        public double GetMWSt()
        {
            return mwst;
        }

      
    }
}
