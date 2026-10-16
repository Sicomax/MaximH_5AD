using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef14_MaximH_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * 16/10/26
             * Random
             */

            // Velden
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;
            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                // Toon keuzemenu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("    1) Maak 2 randoms zonder voorwaarde \n    2) Maak 2 verschillende willekeurige getallen \n    3) Maak 2 verschillende willekeurige getallen met max-waarde \n    4) Maak twee verschillende willekeurige getallen met een max- en min-waarde \n    5) Aflsuiten");

                try
                {
                    // Vraag de keuze + opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Als 1:
                    // Scherm wissem
                    Console.Clear();

                    if (_keuze == 1)
                    {
                        //Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()   }");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 2
                    else if (_keuze == 2)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        //Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 3
                    else if (_keuze == 3)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next(10);
                        _getal2 = _rdm1.Next(10);

                        //Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 4
                    else if (_keuze == 4)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next(10, 100);
                        _getal2 = _rdm1.Next(10, 100);

                        //Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    // Als 5
                    else if (_keuze == 5)
                    {
                        Console.WriteLine("Tot een volgende keer!");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // In elk ander geval
                    else
                    {
                        //Foutmelding
                        Console.WriteLine("U gaf geen geldige keuze in.");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    //Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 5);
        }
    }
}
