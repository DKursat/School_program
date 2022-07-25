using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace array_sortierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();

            Console.Write("Wie viele Zahlen sollen generiert werden? ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            int[] zahlen = new int[anzahl];

            Console.Write("Welche Zahl wollen sie rausfiltern? ");
            int abfrage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bis zu welcher Zahl sollen zahlen generiert werden? ");
            int zufallBis = Convert.ToInt32(Console.ReadLine()); 

            int x = 0;
            int y = 0;

            int zahl = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = zufall.Next(zufallBis);
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                
                
                if (zahlen[i] == abfrage)
                {
                    y++;
                    Console.WriteLine("----------{0}------------",zahlen[i]);

                }
                else 
                {
                    x++;
                    Console.WriteLine(zahlen[i]);
                }
                
            }

            Console.WriteLine("Die Zahl {0} war {1} mal vorhanden.",abfrage,y);
            Console.WriteLine("Es gab {0} andere zahlen.",x);



        }
    }
}
