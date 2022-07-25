using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Vektorrechung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            int auswahl;
            
            //Vektor public
            int x1 = 0, y1 = 0, z1 = 0;
            
            //Klassen
            Vektor a = new Vektor(x1, y1,z1);
            Vektor b = new Vektor(x1, y1, z1);
            Vektor c = new Vektor(x1, y1, z1);


            Console.WriteLine("Vektor Rechnung");
            Console.WriteLine("---------------");
            Console.WriteLine("\n");


            Console.WriteLine("Bitte tragen sie jetzt den ersten Vektor ein. (Bitte achten Sie drauf das es Ganze Zahlen sind!)");
            a.Eingabe();

            Console.WriteLine(a.Ausgabe());
            


            Console.WriteLine("Bitte tragen sie jetzt den zweiten Vektor ein. (Bitte achten Sie drauf das es Ganze Zahlen sind!)");
            b.Eingabe();
            
           




            //Addition
            c= a + b;
            Console.WriteLine("Der Neue Vektor lautet ({0})", c);

            //Subtraktion
            c = a - b;
            Console.WriteLine("Der Neue Vektor lautet ({0})", c);
            
            //Multiplikation
            c = a * b;
            Console.WriteLine("Der Neue Vektor lautet ({0})", c);
           
            //Division
            c = a / b;
            Console.WriteLine("Der Neue Vektor lautet ({0})", c);


          
          

           // Abstand zweier Punkte berechnen
            Console.WriteLine("Sie können den Abstand Zwischen Vektor 1 und 2 berechnen oder 2 und 3 oder 1 und 3 Sie können auch 1 oder 2 oder 3 mit dem Ursprung berechnen Also  den Vektor  (0 0 0)");
            Console.WriteLine("\n");
            Console.WriteLine("Sie haben die folgenden möglichkeiten");
            Console.WriteLine("1: Vektor eins ({0}{1}{2}) und zwei({3}{4}{5}) Berechnen" /*Vektor eins*/, a.x1, a.y1, a.z1,/*Vektor zwei*/ b.x1, b.y1, b.z1);
            Console.WriteLine("2: Vektor eins ({0}{1}{2}) und Ursprung({3}{4}{5}) Berechnen" /*Vektor eins*/, a.x1, a.y1, a.z1,/* Ursprung */0, 0, 0);
            Console.WriteLine("3: Vektor zwei ({0}{1}{2}) und Ursprung({3}{4}{5}) Berechnen"/*Vektor zwei*/, b.x1, b.y1, b.z1,/*Ursprung*/ 0, 0, 0);
            Console.WriteLine("4:Sie haben auch die Möglichkeit alle Vektoren berechnen zulassen!"/*Alles " Zusammen" Gerechnet*/);
            Console.WriteLine("\n");
            Console.Write("Bitte geben sie einen der oben genannten möglichkeiten an: ");
            auswahl = Convert.ToInt32(Console.ReadLine());
            
            
        }
    }    
    //Vektor Rechnungen
    class Vektor
    {
        private int x, y, z;
      

        public Vektor()
        {
            x = 0;
            y = 0;
            z = 0;
        }

     
        public Vektor(int x1, int y1, int z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }

        //Vektor eingabe
        public void Eingabe()
        {
            
            Console.Write("X = ");
              x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
              y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z = ");
              z = Convert.ToInt32(Console.ReadLine());
        }

        //Ausgabe vom Vektor

        public int Ausgabe()
        { Vektor Ausgabe = new Vektor();
            Ausgabe.x = x;
            Ausgabe.y = y;
            Ausgabe.z = z;
            return Ausgabe;
        }
        
        //Addition
        public static Vektor operator + (Vektor lhs, Vektor rhs)
        {

            Vektor erg = new Vektor();
            erg.x = lhs.x + rhs.x;
            erg.y = lhs.y + rhs.y;
            erg.z = lhs.z + rhs.z;
            

            return erg;
          
        }
        //Subtraktion
        public static Vektor operator -(Vektor lhs, Vektor rhs)
        {
            Vektor erg = new Vektor();
            erg.x = lhs.x - rhs.x;
            erg.y = lhs.y - rhs.y;
            erg.z = lhs.z - rhs.z;


            return erg;

        }
        //Multiplikation
        public static Vektor operator *(Vektor lhs, Vektor rhs)
        {

            Vektor erg = new Vektor();
            erg.x = lhs.x * rhs.x;
            erg.y = lhs.y * rhs.y;
            erg.z = lhs.z * rhs.z;



            return erg;

        }
        //Division
        public static Vektor operator /(Vektor lhs, Vektor rhs)
        {
            Vektor erg = new Vektor();
            erg.x = lhs.x / rhs.x;
            erg.y = lhs.y / rhs.y;
            erg.z = lhs.z / rhs.z;
            

            return erg;

        }
        //Diverse Berechnungen
        //Länge eines Vektors
        public double lange()
        {
            double erg;
         
            return erg= Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));

        }
        
        //Abstand zweier Punkte berechnen


    }




}
