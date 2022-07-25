using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7_1_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 0, y= 0;
            Viereck v = new Viereck();
            Kreis k = new Kreis();

            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt();
            Punkt p3 = new Punkt();
            Punkt p4 = new Punkt();
            double radius = 2.5;

            v.SetPunkte();
            k.Ausgabe();

            v.Ausgabe();
            Console.WriteLine();
            
            k.Ausgabe();
            Console.WriteLine();



        }
    }
 
    class GrundFrom
    {
        int x = 0;
        int y = 0;
        int z = 0;
        protected double P1;
        protected double P2;
        protected double P3;
        protected double P4;
        public void SetPunkte()
        {

        }

        public void Ausgabe()
        {
           

            
        }
    }
    class Punkt
    {
        private int x;
        public void SetPunkte()
        {

        }
     
    }
    class Viereck : GrundFrom
    {
        
        public void ViereckAusgabe()
        {


         
        
        }
    }
    class Kreis : GrundFrom
    { 
    
    }

}
