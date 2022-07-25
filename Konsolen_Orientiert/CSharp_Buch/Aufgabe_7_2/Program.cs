using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Landtier e = new Landtier("Elefant","30");
            Landtier n = new Landtier("Nashorn","20");
            Wassertier w = new Wassertier("Wal", "500");
            Wassertier d = new Wassertier("Delfin","800");

        }
    }
    class Tier
    {
        protected string name;

        public Tier(string a)
        {
            name = a;

        }

        public void Ausgabe()
        {
            Console.WriteLine("Name des Tiers:    " + name);
            
        }
    }
    class Landtier : Tier
    {
        private string Geschwindigkeit;

        public Landtier(string a, string b) : base(a)
        {
            name = a;
            Geschwindigkeit = b;

        }

       
    }
    class Wassertier : Tier
    {
        private string Tauchzeit;

        public Wassertier(string a, string b) : base(a)
        {
            name = a;
            Tauchzeit = b;

        }
    }
}
    


