using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennspiel
{
    class CAuto
    {
        //Variablen
        // Link Homeassistant api https://funprojects.blog/2020/12/12/home-assistant-rest-api/
        // API docs https://developers.home-assistant.io/docs/rest/
        private double a, t, nullBisHundert;
        private string name, farbe;
        private bool sieger;

        //Konstruktoren
        public CAuto(double a, string farbe, string name, double nullBisHundert)
        {
            this.a = a;
            this.name = name;
            this.farbe = farbe;
            this.nullBisHundert = nullBisHundert;
        }

        //Eigenschaften
        public double Beschleunigung
        {
            get { return a; }
            set { a = value; }            
        }
        public string Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Sieger
        {
            get { return sieger;           }   
            set { sieger = value; }
        }

        //Methoden
        private void ZeitBerechnung()
        {
            a = 27.78 / nullBisHundert;
            t = Math.Sqrt((2 * 400) / a);
        }
        public static List<CAuto> Rennen(List<CAuto> _autos)
        {
            foreach (CAuto auto in _autos)
            {
                auto.ZeitBerechnung();
            }
            return _autos.OrderBy(auto => auto.nullBisHundert).ToList();
        }
    }
}
