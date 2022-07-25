using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            CVektor Vektoren = new CVektor();
            Vektoren.Eingabe();
            Console.WriteLine("\n");
            Vektoren.Ausgabe();
            Console.WriteLine("\n");

            Console.WriteLine(Vektoren.Länge());

        }
    }
    class CVektor
    {
        private double x;
        private double y;
        private double z;
        private double Ergebnis;

        public void Eingabe()
        {
            Console.WriteLine("Bitte geben sie die Vektoren an");
            Console.Write("Der Vektor X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Der Vektor Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Der Vektor Z: ");
            z = Convert.ToDouble(Console.ReadLine());




        }

        public void Ausgabe()
        {
            Console.WriteLine("Ihr Vektor Lautet:");
            Console.WriteLine("({0})\n({1})\n({2})", x, y, z);
        }

        public double Länge()
        {
           
            Ergebnis = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)); ;
            return Ergebnis;
        }




    }

}
