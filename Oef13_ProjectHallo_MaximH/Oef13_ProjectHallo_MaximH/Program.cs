using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oef13_ProjectHallo_MaximH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Project Hallo
             * Maxim Heyndrickx
             * 16/10/26
             */

            // Velden
            Byte _keuze = 0;
            string _naamGebruiker = null;
            // Programma
            do
            {
                //Scherm wissen
                Console.Clear();

                //Stap 1: Toon het keuzemenu(hallo, hallo + naam, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n    1) Hallo Wereld \n    2) Hallo + naam \n    3) aflsuiten");
                try
                {
                    //Stap 2: Vraag de keuze + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    //Stap 3
                    //	Als 1:
                    if (_keuze == 1)
                    {
                        //o Stap 4: Toon juiste tekst
                        Console.WriteLine("Hallo wereld!");
                    }
                    //	Als 2:
                    else if (_keuze == 2)
                    {
                        //o Stap 5: Vraag naam +opslaan
                        Console.WriteLine("Wat is jouw naam? ");
                        _naamGebruiker = Console.ReadLine();

                        // Scherm wissen
                        Console.Clear();
                        //o Stap 6: Toon juiste tekst
                        Console.WriteLine($"Hallo {_naamGebruiker}!");

                    }
                    //	Als 3
                    else if (_keuze == 3)
                    {
                        //o Stap 7: Toon afsluittekst
                        Console.WriteLine("Tot een volgende keer!");
                    }
                    // Als het iets anders is
                    else
                    {
                        //foutmelding
                        Console.WriteLine("U gaf geen geldige keuze in!");
                    }   
                    // Toon de tekst
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    //Foutmelding
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om naar het keuzemenu te gaan.");
                    Console.ReadKey();
                }
                //	Als niet 3
                //o Stap 8: Terug naar stap 1
            }
            while (_keuze != 3);
        }
    }
}
