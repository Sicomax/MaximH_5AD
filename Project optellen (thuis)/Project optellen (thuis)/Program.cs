using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_optellen__thuis_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * Project optellen
             * 22/10/26
             */

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _totaal = 0;
            // Programma
            Console.WriteLine("Geef het eerste getal: ");
            _getal1 = int.Parse(Console.ReadLine());

            // Scherm wissen
            Console.Clear();

            Console.WriteLine("Geef het tweede getal: ");
            _getal2 = int.Parse(Console.ReadLine());

            // Opsomming
            _totaal = _getal1 + _getal2;

            // Laten zien
            // Scherm wissen
            Console.Clear();

            Console.WriteLine($"De opsomming van jouw twee getallen is: {_totaal}");
            Console.WriteLine("Druk op enter om verder te gaan.");
            Console.ReadKey();
        }
    }
}
