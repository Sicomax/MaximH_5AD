using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef17_ProjectStringFuncties_MaximH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * Project Stringfuncties
             * 27/10/26
             */

            // Velden
            Byte _keuze = 0;
            string _gegevenGebruiker = null;
            Byte _aantalTekens = 0;
            //Programma
            do
            {
                //SCherm wissen
                Console.Clear();

                // Keuzemenu
                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                Console.WriteLine("\n    1) Geef een woord of een zin in \n    2) Bewerk de zin \n    3) Afsluiten");


                try
                {
                    //Vraag keuze
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());
                    // Als 1
                    if (_keuze == 1)
                    {
                        // Scherm wissen
                        Console.Clear();

                        Console.WriteLine("Geef uw woord of zin in: ");
                        _gegevenGebruiker = Console.ReadLine();
                    }
                    // Als 2
                    //	Zeg hoeveel tekens het bevat
                    // Scherm wissen
                    Console.Clear();

                    if (_keuze == 2)
                    {
                        //Scherm wissen 
                        Console.Clear();
                        Console.WriteLine($"Uw ingegeven heeft {_gegevenGebruiker.Length.ToString()} aantal tekens.");
                        _aantalTekens = Convert.ToByte(_gegevenGebruiker.Length);
                        Console.WriteLine("Druk op enter om naar het volgende te gaan.");
                        Console.ReadKey();

                        //	Zet elke letter in een hoofdletter en toon het woord.
                        // Scherm wissen
                        Console.Clear();

                        //	Zet elke letter in een kleine letter en toon het woord.
                        Console.WriteLine($"Uw ingegeven in kleine letters is: {_gegevenGebruiker.ToLower()}.");
                        Console.WriteLine("Druk op enter om naar het volgende te gaan.");
                        Console.ReadKey();

                        //	Wat de eerste 3 tekens zijn(toon deze op het scherm)
                        //Scherm wissen
                        Console.Clear();

                        Console.WriteLine($"De eerste 3 tekens van uw ingegeven zijn: {_gegevenGebruiker.Substring(0, 3)}.");
                        Console.WriteLine("Druk op enter om naar het volgende te gaan.");
                        Console.ReadKey();

                        //	Wat de laatste 4 tekens zijn(toon deze op het scherm)
                        //Scherm wissen
                        Console.Clear();

                        Console.WriteLine($"De laatste vier tekens van uw ingegeven zijn: {_gegevenGebruiker.Substring(_aantalTekens - 4, 4)}");
                        Console.WriteLine("Druk op enter om naar het volgende te gaan.");
                        Console.ReadKey();

                        //	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                        // Scherm wissen
                        Console.Clear();

                        _gegevenGebruiker = $"     {_gegevenGebruiker}     ";
                        Console.WriteLine("Druk op enter om naar het volgende te gaan.");
                        Console.ReadKey();

                        //	Verwijder de spaties voor het woord(toon op het scherm)
                        //	Verwijder de spaties achter het woord(toon op het scherm)
                        //	Zet 5 spaties voor en achter de zin. (toon op het scherm)
                        //	Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)
                        //	Zoek of er een e in het woord of de zin zit
                        //a.Als er een e in de zin zit vervang je die door het cijfer 3
                        //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”
                        //	Vraag de gebruiker een 2de zin in te geven. 
                        //a.Rangschik deze woorden alfabetisch
                        //b.Tenzij ze identiek zijn, dan zeg je: “je gaf hetzelfde woord of dezelfde tekst in” 
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen keuze in.");
                    Console.WriteLine("Druk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 3);
        }
    }
}
