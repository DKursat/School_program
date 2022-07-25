using System;

namespace zeilen_spalten_summen
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Programm zur Berechnung der Zeilensummen\n\teiner 3 x 3 Matrix");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Geben sie eine 3x3 Matrix ein:");

            for (int z = 0; z < 3; z++)
            {
                for (int s = 0; s < 3; s++)
                {
                    matrix[z, s] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int zeile0 = 0, zeile1 = 0, zeile2 = 0;
            for (int z = 0; z < 3; z++)
            {
                for (int s = 0; s < 3; s++)
                {
                    if (z == 0)
                    {
                        zeile0 += matrix[z, s];
                    }
                    else if (z == 1)
                    {
                        zeile1 += matrix[z, s];
                    }
                    else if (z == 2)
                    {
                        zeile2 += matrix[z, s];
                    }
                }
            }

            Console.WriteLine("Die Summe der nullten Zeile = " + zeile0);
            Console.WriteLine("Die Summe der ersten Zeile = " + zeile1);
            Console.WriteLine("Die Summe der zweiten Zeile = " + zeile2);

            int spalte0 = 0, spalte1 = 0, spalte2 = 0;

            for (int s = 0; s < 3; s++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (s == 0)
                    {
                        spalte0 += matrix[z, s];
                    }
                    else if (s == 1)
                    {
                        spalte1 += matrix[z, s];
                    }
                    else if (s == 2)
                    {
                        spalte2 += matrix[z, s];
                    }
                }
            }


            Console.WriteLine("Die Summe der nullten Spalte = " + spalte0);
            Console.WriteLine("Die Summe der ersten Spalte = " + spalte1);
            Console.WriteLine("Die Summe der zweiten Spalte = " + spalte2);
        }
    }
}
