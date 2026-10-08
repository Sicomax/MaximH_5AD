using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Rekensom_MH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Project Rekensom
             * Maxim Heyndrickx
             * 08/10/26
             */

            //velden
            int _eersteGetal = 0;
            int _tweedeGetal = 0;
            int _som = 0;
            int _vermeerderd = 0;
            int _vermenigvuldig = 0;
            int _gedeeld = 0;
            //programma
            try
            {
                //Stap 1: vraag natuurlijke getallen + opslaan
                Console.Write("Geef een natuurlijk getal in om te berekenen: ");
                _eersteGetal = int.Parse(Console.ReadLine());

                //Scherm wissen
                Console.Clear();

                Console.Write("Geef het tweede natuurlijke getal: ");
                _tweedeGetal = int.Parse(Console.ReadLine());

                //Scherm wissen
                Console.Clear();

                //Stap 2: tel de 2 getallen op +opslaan
                _som = _eersteGetal + _tweedeGetal;

                //Stap 3: toon de uitkomst
                Console.WriteLine($"U gaf het getal {_eersteGetal.ToString()} en getal {_tweedeGetal.ToString()} in.");
                Console.WriteLine($"De som hiervan is {_som.ToString()}");

                //Stap 4: eerste uitkomst +5 + opslaan
                _vermeerderd = _som + 5;

                //Stap 5: uitkomst 2 tonen
                Console.WriteLine($"Dit getal werd vermeerderd met 5. Dit gaf als uitkomst {_vermeerderd.ToString()}.");

                //Stap 6: uitkomst 3 * 10 + opslaan
                _vermenigvuldig = _vermeerderd * 10;

                //Stap 7: uitkomst 3 tonen
                Console.WriteLine($"Daarna werd er vermenigvuldigd met 10. Dit gaf als uitkomst {_vermenigvuldig.ToString()}.");

                //Stap 8: uitkomst 4 / 2 + opslaan
                _gedeeld = _vermenigvuldig / 2;

                //Stap 9: laatste uitkomst tonen
                Console.WriteLine($"Als laatste werd er gedeeld door 2.\nHet uiteindelijke resultaat is {_gedeeld.ToString()}.");
                Console.WriteLine("Druk op enter om verder te gaan.");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Er ging iets fout. \nDruk op enter om verder te gaan.");
                Console.ReadKey();
            }

        }
    }
}
