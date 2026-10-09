using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _09_ProjectGeen100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Project geen 100
             * Maxim Heyndrickx
             * 09/10/26
             */

            //velden
            int _getalGebruiker = 0;
            const int _honderd = 100;
            //programma
            try
            {
                //Stap 1: vraag een positief of negatief getal +opslaan
                Console.WriteLine("Geef een positief getal dat geen 100 is:");
                _getalGebruiker = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();

                //Stap 2: Laten checken of het groter of kleiner is + weergeven
                if (_getalGebruiker < _honderd)
                {
                    Console.WriteLine($"Je getal is kleiner dan {_honderd.ToString()}.");
                    Console.WriteLine("Druk op enter om verder te gaan.");
                    Console.ReadKey();
                }
                else if (_getalGebruiker > _honderd)
                {
                    Console.WriteLine($"Je getal is groter dan {_honderd.ToString()}.");
                    Console.WriteLine("Druk op enter om verder te gaan.");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine($"Je getal is gelijk aan {_honderd.ToString()}.");
                    Console.WriteLine("Druk op enter om verder te gaan.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Je hebt geen getal weergegeven. \nDruk op enter om verder te gaan.");
                Console.ReadKey();
            }

        
        }
    }
}