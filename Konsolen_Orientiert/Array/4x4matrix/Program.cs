using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4x4matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm zur ermittlung von geraden Zahlen\nin einer 4 x 4 Matrix");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Geben Sie beliebige ganze Zahlen für eine 4 x 4 Matrix zeilenweise ein:");

            int[,] zahlen = new int[4, 4];

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    zahlen[j, i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Die geraden Zahlen der Matrix sind in");

            for (int z = 0; z < 4; z++)
            {
                for (int s = 0; s < 4; s++)
                {
                    if (zahlen[z, s] % 2 == 0)
                    {
                        Console.WriteLine("Zeile {0} / Spalte {1} die {2}", z, s, zahlen[z, s]);
                    }
                    
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        }
}
