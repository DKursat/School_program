using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunkt a = new CPunkt();
            CPunkt b = new CPunkt();
            CPunkt c = new CPunkt(5,3);
            int x, y;

            Console.WriteLine("Punkt A:");
            a.eingabe();
            Console.Clear();
            Console.WriteLine("Punkt B:");
            b.eingabe();
            Console.Clear();
           /* Console.WriteLine("Punkt C:");
            c.eingabe();
            Console.Clear();*/

            x = a.ausgabeX(); y = a.ausgabeY();
            Console.WriteLine("Punkt <" + x + " | " + y + ">");
            x = b.ausgabeX(); y = b.ausgabeY();
            Console.WriteLine("Punkt <" + x + " | " + y + ">");
            x = c.ausgabeX(); y = c.ausgabeY();
            Console.WriteLine("Punkt <" + x + " | " + y + ">");
        }
    }






    class CPunkt
    {
        private int x;
        private int y;

        public CPunkt()
        {
            x = 0;
            y = 0;

        }
        public CPunkt(int a, int b)
        {
            x = a;
            y = b;

        }


        public void eingabe()
        {
            Console.WriteLine("Bitte geben sie die X koordinate ein:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben sie die Y koordinate ein:");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public int ausgabeX()
        {
            return x;
        }
        public int ausgabeY()
        {
            return y;
        }


    }
}

    