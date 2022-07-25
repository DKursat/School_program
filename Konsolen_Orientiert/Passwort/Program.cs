using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Passwort
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 3;
            
            

            do
            {
                string pw = "speedo";

                string pwabfrage = "";

                string acc = "Kursat";

                string accAbfrage = "";


                Console.Write("Bitte geben sie ihren Account Namen ein: ");

                accAbfrage = Convert.ToString(Console.ReadLine());

                Console.Write("Bitte geben sie ihr Passwort ein: ");

                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pwabfrage += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pwabfrage.Length > 0)
                        {
                            pwabfrage = pwabfrage.Substring(0, (pwabfrage.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.WriteLine("\n");



                if (accAbfrage == acc && pwabfrage == pw)
                {
                    Console.Clear();

                    Console.WriteLine("Anmelde Daten Korrekt");

                    string text = "Was willst du tun?\n-------------------\n                   |\n                   |\n       There       |\n                   |\n                   |\n                   |\n-------------------\n                   |\n                   |\n          is       |\n                   |\n                   |\n                   |\n-------------------\n                   |\n                   |\n       nothing     |\n                   |\n                   |\n                   |\n-------------------\n                   |\n                   |\n        here       |\n                   |\n                   |\n                   |\n-------------------\n\n";

                    for (int i = 0; i < text.Length; i++)
                        {
                            Console.Write(text[i]);

                            Thread.Sleep(30);
                        }



























                }

                else if (x == 0){
                    Console.Clear();
                    Console.WriteLine("Sie haben keine weiteren versuche mehr.");
                    return;
                
                
                }

                else
                {
                    Console.Clear();
                    Console.Write("Anmeldedaten Inkorrekt. \nSie haben noch {0} weitere versuche\n ", x);
                    x--;

                }



            } while (x >= 0);

            return;





        }
    }
}
