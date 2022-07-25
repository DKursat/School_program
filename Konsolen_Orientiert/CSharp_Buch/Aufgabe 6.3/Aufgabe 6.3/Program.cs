using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAdresse IP = new IPAdresse();

            Console.WriteLine("Bitte geben Sie eine IP-Adresse ein");
            string eigeneIPadresse = Convert.ToString(Console.ReadLine());
            IP.IPeingabe(eigeneIPadresse);
            IP.IPüberprüfung(eigeneIPadresse);

        }
    }

    class IPAdresse
    {
        string IPaufteilung = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
        private string IPadresse = "";
        bool set = false;
        public void IPeingabe(string eigeneIPadresse)
        {
            IPadresse = eigeneIPadresse;
        }

        public string IPüberprüfung(string eigeneIPadresse)
        {
           string[] Splitter = eigeneIPadresse.Split(new char[] {'.'});
            if (Splitter.Length == 4 )
            {
                Console.WriteLine("Die vier Punkte sind enthalten");

            }
            else if(Splitter.Length ==1)
            {
                Console.WriteLine("Dein IP hat an der erste stelle kein punkt");
            }
            else if (Splitter.Length == 2)
            {
                Console.WriteLine("Dein IP hat an der zweiten stelle kein punkt");
            }
            else if (Splitter.Length == 3)
            {
                Console.WriteLine("Dein IP hat an der dritten stelle kein punkt");
            }
            else if (Splitter.Length >= 5)
            {
                Console.WriteLine("Dein IP hat zu viele Punkte");
            }

            if (IPaufteilung == eigeneIPadresse)
            {
                Console.WriteLine("Die Ip ist In Ordnung");
            }
            return eigeneIPadresse;
        }




    }
}
