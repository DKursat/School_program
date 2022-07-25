using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto m = new Auto("Rot","Mercedes","PKW",5,"Limusine",195, "-" , "-");
            Auto m = new Auto("Rot", "Mercedes", "PKW", 5, "Limusine", 195, "-", "-");
            Auto m = new Auto("Rot", "Mercedes", "PKW", 5, "Limusine", 195, "-", "-");
            Auto m = new Auto("Rot", "Mercedes", "PKW", 5, "Limusine", 195, "-", "-");
            Auto m = new Auto("Rot", "Mercedes", "PKW", 5, "Limusine", 195, "-", "-");
            Auto m = new Auto("Rot", "Mercedes", "PKW", 5, "Limusine", 195, "-", "-");
        }
    }

    class Vermietung
    {

    }


    class Auto
    {
        private string Farbe;
        private string Marke;
        private string Typ;
        private string bauart;
        private int Sitz;
        private int Geschwindigkeit;
        private string Zuladung;
        private string Achsen;
        public Auto(string setFarbe, string setMarke, string setTyp, int setSitz, string setbauart, int setGeschwindigkeit, string setZuladung, string setAchsen)
        {
            Farbe = setFarbe;
            Marke = setMarke;
            Typ = setTyp;
            bauart = setbauart;
            Sitz = setSitz;
            Geschwindigkeit = setGeschwindigkeit;
            Zuladung = setZuladung;
            Achsen = setAchsen;

        }
        public void Fahrzeug(string setFarbe, string setMarke, string setTyp, int setSitz, string setbauart, int setGeschwindigkeit, int setZuladung, int setAchsen)
         {
            Farbe = setFarbe;
            Marke = setMarke;
            Typ = setTyp;
            bauart = setbauart;
            Sitz = setSitz;
            Geschwindigkeit = setGeschwindigkeit;
            Zuladung = setZuladung;
            Achsen = setAchsen;


         }

    }

    class Mieter
    {

    }



}
