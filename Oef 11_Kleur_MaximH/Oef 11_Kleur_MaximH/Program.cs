using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oef_11_Kleur_MaximH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Project Kleur
             * Maxim Heyndrickx
             * 13/10/26
             */

            //velden
            Byte _keuze = 0;

            //Programma
                //Stap 1: laat menu zien
                Console.WriteLine("Kies een kleur door het getal naast de kleur in te geven.");
                Console.WriteLine("  1. Rood \n  2. Groen \n  3. Blauw");

            try
            {
                //Stap 2: vraag keuze +opslaan
                Console.Write("\nUw keuze: ");
                _keuze = Byte.Parse(Console.ReadLine());

                //scherm leegmaken
                Console.Clear();

                //Stap 3: 
                //	Als keuze rood
                if (_keuze == 1)
                {
                    //o   Toon tekst
                    Console.WriteLine("U koos voor de kleur rood!");
                }

                //	Als keuze groen
                else if (_keuze == 2)
                {
                    //o   Toon tekst
                    Console.WriteLine("U koos voor de kleur groen!");
                }
                

                //	Als keuze blauw
                else if (_keuze == 3)
                {
                    //o   Toon tekst
                    Console.WriteLine("U koos voor de kleur blauw!");
                }
                else
                {
                    // foutmelding
                    Console.WriteLine("U gaf geen geldige keuze in!");
                }
            }
            catch
            {
                //scherm leegmaken
                Console.Clear();

                Console.WriteLine("Je hebt geen getal in gegeven.");
                Console.WriteLine("Druk op enter om verder te gaan.");
                Console.ReadKey();
            }
        }
    }
}
