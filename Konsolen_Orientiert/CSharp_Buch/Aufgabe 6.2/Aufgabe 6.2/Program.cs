using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6._2
{



    class Program
    {
        static void Main(string[] args)
        {
            CZahl A = new CZahl();
            int zahl;
            do
            {



                bool pass = false;
                do
                {
                    Console.WriteLine("Bitte geben sie eine Zahl zwischen 0 und 999 an:");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    pass = A.Pass(zahl);
                    Console.Clear();


                } while (pass == false);


                Console.WriteLine(A.Ausgabe(zahl));
            } while (true);

        }
    }


    class CZahl
    {
        private string ausgabe;

        public bool Pass(int zahl)
        {


            bool pass;
            if (zahl >= 0 && zahl < 1000)
            {
                pass = true;
            }
            else
            {
                pass = false;
            }

            return pass;


        }

        public string Ausgabe(int zahl)
        {
            ausgabe = " ";
            String[] ones = new String[13];  ones[1] = "eins"; ones[2] = "zwei"; ones[3] = "drei"; ones[4] = "vier"; ones[5] = "fünf"; ones[6] = "sechs"; ones[7] = "sieben";
            ones[8] = "acht"; ones[9] = "neun"; ones[10] = "zehn"; ones[11] = "elf"; ones[12] = "zwölf";
            String[] tens = new String[101]; tens[20] = "zwanzig"; tens[30] = "dreissig"; tens[40] = "vierzig";
            tens[50] = "fünfzig"; tens[60] = "sechzig"; tens[70] = "siebzig"; tens[80] = "achtzig"; tens[90] = "neunzig"; tens[100] = "hundred";
            if (zahl >= 100 && zahl < 200)
            {
                ausgabe = "einhundert";
                zahl -= 100;
            }
            if (zahl >= 200 && zahl < 300)
            {
                ausgabe = "zweihundert";
                zahl -= 200;
            }
            if (zahl >= 300 && zahl < 400)
            {
                ausgabe = "dreihundert";
                zahl -= 300;
            }
            if (zahl >= 400 && zahl < 500)
            {
                ausgabe = "vierhundert";
                zahl -= 400;
            }
            if (zahl >= 500 && zahl < 600)
            {
                ausgabe = "fünfhundert";
                zahl -= 500;
            }
            if (zahl >= 600 && zahl < 700)
            {
                ausgabe = "sechshundert";
                zahl -= 600;
            }
            if (zahl >= 700 && zahl < 800)
            {
                ausgabe = "siebenhundert";
                zahl -= 700;
            }
            if (zahl >= 800 && zahl < 900)
            {
                ausgabe = "achthundert";
                zahl -= 800;
            }
            if (zahl >= 900 && zahl < 1000)
            {
                ausgabe = "neunhundert";
                zahl -= 900;
            }
            ausgabe += " ";

            if (zahl <= 12)
            {
                ausgabe += ones[zahl];
            }
            if (zahl > 12 && zahl < 20)
            {
                ausgabe += ones[zahl - 10];
                ausgabe += ones[10];
            }
            if (zahl >= 20 && zahl < 30)
            {
                ausgabe += ones[zahl - 20];
                ausgabe += " und " + tens[20];
            }
            if (zahl >= 30 && zahl < 40)
            {
                ausgabe += ones[zahl - 30];
                ausgabe += " und " + tens[30];
            }
            if (zahl >= 40 && zahl < 50)
            {
                ausgabe += ones[zahl - 40];
                ausgabe += " und " + tens[40];
            }
            if (zahl >= 50 && zahl < 60)
            {
                ausgabe += ones[zahl - 50];
                ausgabe += " und " + tens[50];
            }
            if (zahl >= 60 && zahl < 70)
            {
                ausgabe += ones[zahl - 60];
                ausgabe += " und " + tens[60];
            }
            if (zahl >= 70 && zahl < 80)
            {
                ausgabe += ones[zahl - 70];
                ausgabe += " und " + tens[70];
            }
            if (zahl >= 80 && zahl < 90)
            {
                ausgabe += ones[zahl - 80];
                ausgabe += " und " + tens[80];
            }
            if (zahl >= 90 && zahl < 100)
            {
                ausgabe += ones[zahl - 90];
                ausgabe += " und " + tens[90];
            }





            return ausgabe;
        }

    }


}


