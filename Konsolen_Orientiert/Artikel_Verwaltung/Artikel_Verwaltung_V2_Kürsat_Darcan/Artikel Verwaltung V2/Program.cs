using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;


namespace Artikel_Verwaltung_V2
{
    class Program
    {
        struct Daten
        {
            public String Name;
            public double Preis;
            public int Bestand;
            public int Artikelnummer;
        };
        static void Main(string[] args)
        {

            String Abfrage = "";

            Daten Temp = new Daten();
            ArrayList Artikel = new ArrayList();
            Menu(Abfrage, Temp, Artikel);
            Console.WriteLine();

            Dateneingabe(Abfrage, Temp, Artikel);
            Console.WriteLine();

            Datenausgabe(Abfrage, Temp, Artikel);

            Datenlöschen(Abfrage, Temp, Artikel);
        }
        static void Menu(String Abfrage, Daten Temp, ArrayList Artikel)
        {

            do
            {
                Console.Clear();
                

                    Console.WriteLine("--------------------");
                    Console.WriteLine("|Artikel Verwaltung|");
                    Console.WriteLine("--------------------");
                   
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|1.Neue Artikeldaten erstellen|");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------");
                Console.WriteLine("|2.Artikeldaten ausgeben|");
                Console.WriteLine("-------------------------");
                Console.WriteLine("------------------------");
                Console.WriteLine("|3.Artikeldaten löschen|");
                Console.WriteLine("------------------------");
                Console.WriteLine("--------------------");
                Console.WriteLine("|4.Programm beenden|");
                Console.WriteLine("--------------------");
                Console.WriteLine("\n");
                Console.Write("Bitte geben sie die Nummer an: ");
                int menu = Convert.ToInt32(Console.ReadLine());


                Console.Clear();
                switch (menu)
                {
                    case 1:
                        {
                            Dateneingabe(Abfrage, Temp, Artikel);

                        }
                        break;
                    case 2:
                        {

                            Datenausgabe(Abfrage, Temp, Artikel);


                        }
                        break;

                    case 3:
                        {
                            Datenlöschen(Abfrage, Temp, Artikel);

                        }
                        break;
                    case 4:
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Console.WriteLine("Das Programm wird Beendet!!!!");
                                Thread.Sleep(2000);
                            }
                            System.Environment.Exit(0);
                        }
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Wollen sie das Programm Verlassen oder wollen sie Noch bleiben (Verlassen/Bleiben)");
                Abfrage = Convert.ToString(Console.ReadLine());
            } while (Abfrage == "Bleiben");

        }
        static void Dateneingabe(String Abfrage, Daten Temp, ArrayList Artikel)
        {
            do
            {
                Console.WriteLine("Nummer Eingeben:");
                Temp.Artikelnummer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name Eingeben:");
                Temp.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Preis Eingeben:");
                Temp.Preis = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bestand Eingeben:");
                Temp.Bestand = Convert.ToInt32(Console.ReadLine());
                Artikel.Add(Temp);
                Console.WriteLine("Willst du weitere Artikel eingeben?");
                Abfrage = Convert.ToString(Console.ReadLine());
                Console.Clear();


            } while (Abfrage == "ja" || Abfrage == "Ja");

            Menu(Abfrage, Temp, Artikel);

        }
        static void Datenausgabe(String Abfrage, Daten Temp, ArrayList Artikel)
        {

            for (int i = 0; i < Artikel.Count; i++)
            {
                Temp = ((Daten)Artikel[i]);
                if (Temp.Artikelnummer == 0)
                {

                }
                else
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("|Nummer:  " + Temp.Artikelnummer + "\t|");
                    Console.WriteLine("|Name:    " + Temp.Name + "\t|");
                    Console.WriteLine("|Preis:   " + Temp.Preis + "Euro\t|");
                    Console.WriteLine("|Bestand: " + Temp.Bestand + "\t|");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Bitte bestätigen sie mit Enter damit sie zurück zum Menu zu kommen");
            Console.ReadKey();
            Menu(Abfrage, Temp, Artikel);

        }
        static void Datenlöschen(String Abfrage, Daten Temp, ArrayList Artikel)
        {
            for (int z = 0; z < 2;)
            {

                Console.Clear();

                Console.Write("Bitte Geben sie die Artikel Nummer Ein : ");
                int suche = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                for (int sucheZ = 0; sucheZ < Artikel.Count; sucheZ++)
                {
                    Temp = ((Daten)Artikel[sucheZ]);

                    if (suche == Temp.Artikelnummer)
                    {
                        Console.WriteLine("Ihr Gesuchte Artieklnummer lautet "+ suche);
                        Console.WriteLine("-----------------");
                        Console.WriteLine("|Nummer:  " + Temp.Artikelnummer + "\t|");
                        Console.WriteLine("|Name:    " + Temp.Name + "\t|");
                        Console.WriteLine("|Preis:   " + Temp.Preis + "Euro\t|");
                        Console.WriteLine("|Bestand: " + Temp.Bestand + "\t|");
                        Console.WriteLine("-----------------");
                        Console.WriteLine();
                        Console.WriteLine("Wollen sie diese Artikel löschen (ja/nein)");
                        Abfrage = Convert.ToString(Console.ReadLine());
                        if (Abfrage == "ja" || Abfrage == "Ja")
                        {
                           
                            Console.WriteLine("Ihr Artikel mit den Artikelnummer {0} wurde Gelöscht", suche);
                            Artikel.Remove(Temp);

                            Console.WriteLine("Wollen sie ein anderes Artikel löschen?");
                            Abfrage = Convert.ToString(Console.ReadLine());
                            if (Abfrage == "ja"|| Abfrage == "Ja")
                            {
                                Datenlöschen(Abfrage, Temp, Artikel);

                            }
                            else if (Abfrage == "nein" || Abfrage == "Nein")
                            {
                                Menu(Abfrage, Temp, Artikel);
                            }

                        }
                        else if (Abfrage == "nein" || Abfrage == "Nein")
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Console.WriteLine("Ihr Artikel wurde nicht gelöscht sie werden in  den Menü weitergeleitet");
                                Thread.Sleep(2000);
                            }
                            Menu(Abfrage, Temp, Artikel);
                        }

                    }
                   
                }
            }

        }
    }
}
