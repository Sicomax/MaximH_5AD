using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Getallen_MH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Project getallen
             * Maxim Heyndrickx
             * 01/10/2026
             */

            //Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _getal3 = 0;

            //Programma

            try
            {
                //Stap 1: Vraag een eerste getal +opslaan
                Console.WriteLine("Geef een eerste natuurlijk getal: ");
                _getal1 = int.Parse(Console.ReadLine());

                //Scherm leegmaken
                Console.Clear();
            
                //Stap 2: Vraag een tweede getal +opslaan
                Console.WriteLine("Geef een tweede natuurlijk getal: ");
                _getal2 = int.Parse(Console.ReadLine());

                //Scherm leegmaken
                Console.Clear();
            
                //Stap 3: Vraag een derde getal +opslaan
                Console.WriteLine("Geef een derde natuurlijk getal: ");
                _getal3 = int.Parse(Console.ReadLine());

                //Scherm leegmaken
                Console.Clear();

                //Stap 4: Toon de juiste tekst
                Console.WriteLine($"Dit is het derde getal: {_getal3.ToString()}. \nDit is het tweede getal: {_getal2.ToString()}. \nDit is het eerste getal: {_getal1.ToString()}.");
                Console.WriteLine("\nDruk op enter om verder te gaan");
                Console.ReadKey();
            }
            catch
            {   
                //scherm leegmaken + foutcode weergeven
                Console.Clear();
                Console.WriteLine("Er ging iets fout.");
            }
            
        }
    }
}
