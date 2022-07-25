using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrayslist
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList Artikel = new ArrayList(200) { };
            int a = 0;
            int b = 1;
            do {
                Console.WriteLine("Bitte gib ein Zahl an");
                Artikel.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Anzahl");
      
                Artikel[a] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben sie den Name ein");
                Artikel[a] = a + 1;
                Console.WriteLine("Wollen sie Diesen Vorgang wiederholen");
                b = Convert.ToInt32(Console.ReadLine());

            } while (b == 1);




            for (int i = 0; i < 1; i++)
            {
                
                    

                


            }

        }
    }
}

