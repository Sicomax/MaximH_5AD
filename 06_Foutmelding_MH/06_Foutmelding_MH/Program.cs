using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Foutmelding_MH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Project Foutmelding
             * Maxim Heyndrickx
             * 01/10/2026
             */


            //Velden
            int _getal = 0;

            //Programma

            try
            {
                //Stap 1: Vraag een getal + opslaan
                Console.Write("Geef een natuurlijk getal: ");
                _getal = int.Parse(Console.ReadLine());

                //Stap 2: Toon de tekst of de foutmelding
                Console.WriteLine($"U gaf het volgende getal in: {_getal.ToString()}");

            }
            catch
            {
                //Scherm leegmaken
                Console.Clear();

                //Stap 2: of toon de foutmelding
                Console.WriteLine("Er ging iets fout.");
            }
        }
    }
}
