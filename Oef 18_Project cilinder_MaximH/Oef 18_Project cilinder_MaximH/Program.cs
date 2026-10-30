using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_18_Project_cilinder_MaximH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * project cilinder
             * 29/10/26
             */

            // Velden
            Byte _keuze = 0;
            const byte _twee = 2;
            double _straal = 0;
            double _hoogte = 0;
            double _berekeningInhoud = 0;
            double _berekeningOmtrek = 0;
            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();


                // Keuzemenu
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n    1) Berekeningen van de cilinder \n    2) Aflsuiten");

                try
                {
                    // Vraag de keuze + opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());


                    // Scherm wissen
                    Console.Clear();

                    //Stap 1: vraag de straal van het grondvlak van de cilinder + opslaan
                    if (_keuze == 1)
                    {
                        Console.WriteLine("Wat is de straal van het grondvlak van de cilinder? ");
                        _straal = Double.Parse(Console.ReadLine());

                        //Stap 2: vraag de hoogte van de cilinder +opslaan
                        // Scherm wissen
                        Console.Clear();

                        Console.WriteLine("Wat is de hoogte van de cilinder? ");
                        _hoogte = Double.Parse(Console.ReadLine());

                        //Stap 3: bereken de inhoud
                        _berekeningInhoud = _hoogte * Math.Pow(_straal, 2) * Math.PI;

                        //Stap 4: bereken de omtrek
                        _berekeningOmtrek = Math.PI * _straal * _hoogte + _twee * Math.Pow(_straal, 2) * Math.PI;
                        //Stap 5: geef de resultaten weer
                        // Scherm wissen
                        Console.Clear();

                        Console.WriteLine($"De inhoud van de cilinder is {_berekeningInhoud.ToString()}, en de omtrek van de cilinder is {_berekeningOmtrek.ToString()}.");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 2)
                    {
                        Console.WriteLine("Tot een volgende keer!");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else
                    {
                        //Foutmelding
                        Console.WriteLine("U heeft geen geldige keuze ingevoerd.");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen geldige invoer in.");
                    Console.WriteLine("\nDruk op enter om terug naar het keuzemenu te gaan.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 2);
        }
    }
}
