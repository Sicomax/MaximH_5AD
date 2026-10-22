using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_14_MaximH_MeerDobbelstenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * Project MeerDobbelstenen
             * 20/10/26
             */

            // Velden
            Byte _aantalOgen = 0;
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            int _totaal = 0;
            //Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");
                
                //    Stap 1a: Toon eerste deel keuzemenu (ogen)
                Console.WriteLine("    1) Geef het aantal ogen van de dobbelsteen in.");

                //    Stap 2: Kijk of het aantal ogen is ingegeven
                //Als ja: 
                if (_aantalOgen != 0)
                {
                    // Stap 3: Toon rest van het keuzemenu(werpen, resetten)
                    Console.WriteLine("    2) Werp de dobbelsteen \n    3) Reset het totaal");
                }

                // Stap 1b: Toon eerste deel keuzemenu (afsluiten)
                Console.WriteLine("    4) Aflsuiten");
                try
                {
                    //    Stap 4: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //Als 1:
                    if(_keuze == 1)
                    {
                        // Scherm wissen
                        Console.Clear();

                        // Stap 5: Vraag hoeveel ogen de dobbelsteen heeft +opslaan
                        Console.Write("Geef het aantal ogen dat u voor de dobbelsteen wilt: ");
                        _aantalOgen = Byte.Parse(Console.ReadLine());
                        _aantalOgen++;
                        // _aantalOgen += 1;
                        // _aantalOgen = _aantalOgen +1;
                    }

                    //Als 2: 
                    else if (_keuze == 2)
                    {
                        // Stap 6: Toon de worp van de dobbelsteen + opslaan

                        //Scherm wissen
                        Console.Clear();

                        
                        Byte worp = Convert.ToByte(_rdm1.Next(1, _aantalOgen));
                        Console.WriteLine($"Uw worp is: {worp.ToString()}.");
                        Console.WriteLine("Druk op enter on verder te gaan.");
                        Console.ReadKey();

                        // Stap 7: Toon het totaal van alle worpen tezamen
                        // Scherm wissen
                        Console.Clear();

                        _totaal += worp;
                        Console.WriteLine($"In het totaal heeft u {_totaal.ToString()} geworpen.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het menu.");
                        Console.ReadKey();
                    }
                    
                    //Als 3:
                    else if (_keuze == 3)
                    {
                        // Scherm wissen
                        Console.Clear();

                        // Stap 8: reset het resultaat
                        _totaal = 0;
                        Console.WriteLine($"\nUw totaal is gereset.");
                        Console.WriteLine("\nDruk op enter om terug te keren naar het menu.");
                        Console.ReadKey();
                    }
                    
                    //Als 4:
                    if (_keuze == 4)
                    {
                        // Stap 9: Toon de afsluittekst

                        // Scherm wissen
                        Console.Clear();

                        Console.WriteLine("Tot de volgende keer!");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    
                    //Als niet keuze niet 4
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
            //    Stap 10: keer terug naar stap 1

            }
            while (_keuze != 4);
        }
    }
}
