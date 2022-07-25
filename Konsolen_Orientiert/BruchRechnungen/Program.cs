using System;
using System.Collections;

namespace BruchRechnungen
{
    class Program
    {

        struct bruch
        {
        public int nenner;
        public int zaehler;
        
        
        
        };
        

        static int menuHoehe = 1;
        static void Main(string[] args)
        {

            int y = 0;
            bruch tempDaten;
            tempDaten.nenner = 0;
            tempDaten.zaehler = 0;

            bruch tempDatenA, tempDatenB;
        
            ArrayList brueche = new ArrayList() { 0 };
            brueche.Add(tempDaten);
            brueche.Add(tempDaten);
            ConsoleKeyInfo keyPressed;
            int ez = 0;
            int i = 0;
            




            do
            {

            

            int menu = 0;
            ez = 0;
            while (ez == 0)
            {

                Console.Clear();
                Draw();
                keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.UpArrow && menuHoehe > 1)
                {
                    menuHoehe--;
                }
                else if (keyPressed.Key == ConsoleKey.DownArrow && menuHoehe < 5)
                {
                    menuHoehe++;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    menu = menuHoehe;
                    ez = 1;
                }
            }
            Console.Clear();

                if (menu == 1)
                {


                    do
                    {
                        i = 0;
                    

                    Console.WriteLine("Bitte geben sie den ersten Bruch an.\n");
                    tempDaten = Eingabe(tempDaten);
                    brueche[0] = (tempDaten);

                    Console.Clear();

                    Console.WriteLine("Bitte geben sie den zweiten Bruch an.\n");
                    tempDaten = Eingabe(tempDaten);
                    brueche[1] = (tempDaten);

                    Console.Clear();

                    tempDatenA = ((bruch)brueche[0]);
                    tempDatenB = ((bruch)brueche[1]);

                    tempDaten = Multiplikation(tempDatenA, tempDatenB);

                    

                    

                    Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);

                        Console.WriteLine("Möchten sie den Bruch kürzen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            tempDaten = Kuerzung(tempDaten);

                            Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {
                            
                        }



                        Console.WriteLine("Möchten sie nochmal rechnen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {
                            i++;
                        }



                    } while (i == 0);
                }
                else if (menu == 2)
                {


                    do
                    {
                        i = 0;


                        Console.WriteLine("Bitte geben sie den ersten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[0] = (tempDaten);

                        Console.Clear();

                        Console.WriteLine("Bitte geben sie den zweiten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[1] = (tempDaten);

                        Console.Clear();

                        tempDatenA = ((bruch)brueche[0]);
                        tempDatenB = ((bruch)brueche[1]);

                        tempDaten = Division(tempDatenA, tempDatenB);





                        Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);

                        Console.WriteLine("Möchten sie den Bruch kürzen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            tempDaten = Kuerzung(tempDaten);

                            Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {

                        }

                        Console.WriteLine("Möchten sie nochmal rechnen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {
                            i++;
                        }



                    } while (i == 0);
                }
                else if (menu == 3)
                {


                    do
                    {
                        i = 0;


                        Console.WriteLine("Bitte geben sie den ersten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[0] = (tempDaten);

                        Console.Clear();

                        Console.WriteLine("Bitte geben sie den zweiten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[1] = (tempDaten);

                        Console.Clear();

                        tempDatenA = ((bruch)brueche[0]);
                        tempDatenB = ((bruch)brueche[1]);

                        tempDaten = Addition(tempDatenA, tempDatenB);





                        Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);

                        Console.WriteLine("Möchten sie den Bruch kürzen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            tempDaten = Kuerzung(tempDaten);

                            Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {

                        }

                        Console.WriteLine("Möchten sie nochmal rechnen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {
                            i++;
                        }



                    } while (i == 0);
                }
                else if (menu == 4)
                {


                    do
                    {
                        i = 0;


                        Console.WriteLine("Bitte geben sie den ersten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[0] = (tempDaten);

                        Console.Clear();

                        Console.WriteLine("Bitte geben sie den zweiten Bruch an.\n");
                        tempDaten = Eingabe(tempDaten);
                        brueche[1] = (tempDaten);

                        Console.Clear();

                        tempDatenA = ((bruch)brueche[0]);
                        tempDatenB = ((bruch)brueche[1]);

                        tempDaten = Subtraktion(tempDatenA, tempDatenB);





                        Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);

                        Console.WriteLine("Möchten sie den Bruch kürzen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            tempDaten = Kuerzung(tempDaten);

                            Console.WriteLine("Das ergebnis ist: " + tempDaten.nenner + "/" + tempDaten.zaehler);
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {

                        }

                        Console.WriteLine("Möchten sie nochmal rechnen?");
                        Console.WriteLine("J/N");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                        }
                        else if (keyPressed.Key == ConsoleKey.N)
                        {
                            i++;
                        }



                    } while (i == 0);
                }
                else if (menu == 5)
                {
                    y = 1;


                }





            } while (y == 0);
        }

        static void Draw()

        {
            string eins = "   "; string einsI = "";
            string zwei = "   "; string zweiI = "";
            string drei = "   "; string dreiI = "";
            string vier = "   "; string vierI = "";
            string fuenf = "   "; string fuenfI = "";
            if (menuHoehe == 1)
            {
                eins = ">>>"; einsI = "<<<";
            }
            else if (menuHoehe == 2)
            {
                zwei = ">>>"; zweiI = "<<<";
            }
            else if (menuHoehe == 3)
            {
                drei = ">>>"; dreiI = "<<<";
            }
            else if (menuHoehe == 4)
            {
                vier = ">>>"; vierI = "<<<";
            }
            else if (menuHoehe == 5)
            {
                fuenf = ">>>"; fuenfI = "<<<";
            }

            Console.WriteLine("Menu:");

            if (menuHoehe == 1)
            {
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(eins + "Multiplizieren" + einsI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(zwei + "Dividieren" + zweiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(drei + "Addieren" + dreiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(vier + "Subtrahieren" + vierI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(fuenf + "Beenden" + fuenfI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(">Pfeiltasten< zum auswählen\n>Enter< zum bestätigen");
                Console.WriteLine("---------------------------------");
            }

            else if (menuHoehe == 2)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(eins + "Multiplizieren" + einsI);
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(zwei + "Dividieren" + zweiI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(drei + "Addieren" + dreiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(vier + "Subtrahieren" + vierI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(fuenf + "Beenden" + fuenfI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(">Pfeiltasten< zum auswählen\n>Enter< zum bestätigen");
                Console.WriteLine("---------------------------------");
            }

            else if (menuHoehe == 3)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(eins + "Multiplizieren" + einsI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(zwei + "Dividieren" + zweiI);
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(drei + "Addieren" + dreiI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(vier + "Subtrahieren" + vierI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(fuenf + "Beenden" + fuenfI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(">Pfeiltasten< zum auswählen\n>Enter< zum bestätigen");
                Console.WriteLine("---------------------------------");
            }

            else if (menuHoehe == 4)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(eins + "Multiplizieren" + einsI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(zwei + "Dividieren" + zweiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(drei + "Addieren" + dreiI);
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(vier + "Subtrahieren" + vierI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(fuenf + "Beenden" + fuenfI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(">Pfeiltasten< zum auswählen\n>Enter< zum bestätigen");
                Console.WriteLine("---------------------------------");
            }
            else if (menuHoehe == 5)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(eins + "Multiplizieren" + einsI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(zwei + "Dividieren" + zweiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(drei + "Addieren" + dreiI);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(vier + "Subtrahieren" + vierI);
                Console.WriteLine("---------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fuenf + "Beenden" + fuenfI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(">Pfeiltasten< zum auswählen\n>Enter< zum bestätigen");
                Console.WriteLine("---------------------------------");
            }



        }

        static bruch Eingabe(bruch tempDaten) 
        {
            Console.Write("Bitte geben sie den Zähler an: ");
            tempDaten.nenner = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben sie den Nenner ein: ");
            tempDaten.zaehler = Convert.ToInt32(Console.ReadLine());

            return tempDaten;
        }
        static bruch Multiplikation(bruch tempDatenA,bruch tempDatenB) 
        {
            bruch tempDaten;
            tempDaten.nenner = tempDatenA.nenner * tempDatenB.nenner;
            tempDaten.zaehler = tempDatenA.zaehler * tempDatenB.zaehler;
            return tempDaten;

        }
        static bruch Division(bruch tempDatenA, bruch tempDatenB)
        {
            bruch tempDaten;
            tempDaten.nenner = tempDatenA.nenner * tempDatenB.zaehler;
            tempDaten.zaehler = tempDatenA.zaehler * tempDatenB.nenner;
            return tempDaten;

        }
        static bruch Addition(bruch tempDatenA, bruch tempDatenB)
        {
            bruch tempDaten;
            tempDaten.nenner = tempDatenA.nenner * tempDatenB.zaehler + tempDatenB.nenner * tempDatenA.zaehler;
            tempDaten.zaehler = tempDatenA.zaehler * tempDatenB.zaehler;
            return tempDaten;

        }
        static bruch Subtraktion(bruch tempDatenA, bruch tempDatenB)
        {
            bruch tempDaten;
            tempDaten.nenner = tempDatenA.nenner * tempDatenB.zaehler - tempDatenB.nenner * tempDatenA.zaehler;
            tempDaten.zaehler = tempDatenA.zaehler * tempDatenB.nenner;
            return tempDaten;

        }

        static bruch Kuerzung(bruch tempDaten) 
        {
           
            for (int x = 0; x < 10; x++)
            {

            
            for (int i = 1; i < 100; i++)
            {
                if (tempDaten.nenner % i == 0 && tempDaten.zaehler % i == 0)
                {
                    tempDaten.nenner = tempDaten.nenner / i;
                    tempDaten.zaehler = tempDaten.zaehler / i;
                       
                }
            }

            }


            return tempDaten;
        }
    }
}
