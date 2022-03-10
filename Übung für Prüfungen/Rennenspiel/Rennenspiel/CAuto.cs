using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennenspiel
{
    class CAuto
    {
        //Variabel
        private string _auto, _farbe;
        private double _geschwindigkeit;
        private double a, t;
        //Konstruktor
        public CAuto(string auto, string farbe,double geschwindigkeit)
        {
            _auto = auto;
            _farbe = farbe;
            _geschwindigkeit = geschwindigkeit;
        }
        
        //Eigenschaften
        
        public double Geschwindigkeit
        {
            get { return _geschwindigkeit; }
            set { _geschwindigkeit = value; }
        }

        public string Auto
        {
            get { return _auto; }
            set { _auto = value; }
        }


        public string Farbe
        {
            get { return _farbe; }
            set { _farbe = value; }
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double Zeit
        {
            get { return t; }
            set { t = value; }
        }

        //Methoden


        public double Rennen()
        {
            a = 27.78 / _geschwindigkeit;
            t = Math.Sqrt((2 * 400) / a);

            return t;
        }

    }
}
