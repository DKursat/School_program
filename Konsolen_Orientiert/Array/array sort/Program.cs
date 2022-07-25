using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortierung = new int[10000000];
            Random zufall = new Random();

            for (int i = 0; i < sortierung.Length; i++)
            {
                sortierung[i] = zufall.Next(1000000);
            }
            Array.Sort(sortierung);
            for (int i = 0; i < sortierung.Length; i++)
            {
                Console.Write("{0} ",sortierung[i]);
            }
        }
    }
}
