using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_16_Thuis_Project_Rekensom_MaximH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * Project Rekensom
             * 22/10/26
             */

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _vermeerderd = 0;
            int _vermenigvuldigd = 0;
            int _delen = 0;
            int _som = 0;

            const int _vermeerdering = 5;
            const int _vermenigvuldiging = 10;
            const int _deling = 2;
            //Programma
            Console.WriteLine("Geef het eerste natuurlijke getal in:");
            _getal1 = int.Parse(Console.ReadLine());

            // Scherm wissen
            Console.Clear();
            try
            {
                Console.WriteLine("Geef het tweede natuurlijke getal in: ");
                _getal2 = int.Parse(Console.ReadLine());

                _som = _getal1 + _getal2;

                Console.WriteLine($"U gaf het getal {_getal1.ToString()} en getal {_getal2.ToString()} in.");
                Console.WriteLine($"De som hiervan is {_som.ToString()}");

                _vermeerderd = _som + _vermeerdering;

                Console.WriteLine($"Dit getal werd vermeerder met {_vermeerdering.ToString()}. Dit gaf als uitkomst {_vermeerderd.ToString()}.");

                _vermenigvuldigd = _vermeerderd * _vermenigvuldiging;

                Console.WriteLine($"Daarna werd er vermenigvuldigd met {_vermenigvuldiging.ToString()}. Dit gaf als uitkomst {_vermenigvuldigd.ToString()}.");

                _delen = _vermenigvuldigd / _deling;

                Console.WriteLine($"Als laatste werd er gedeeld door {_deling.ToString()}.");

                Console.WriteLine($"Het uitendelijke resultaat is {_delen.ToString()}.");
                Console.WriteLine("Druk op enter om verder te gaan.");
                Console.ReadKey();
            }
            catch
            {
                // Scherm wissen
                Console.WriteLine("U gaf geen geldig getal in.");
                Console.WriteLine("\nDruk op enter om verder te gaan.");
                Console.ReadKey();
            }
        }
    }
}
