using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _24_MaximH_ProjectRaadspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxim Heyndrickx
             * 13/11/26
             * Project Raadspel
             */

            // Velden
            Byte _keuze = 0;
            const Byte _aantalKansen = 10;
            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                //            Stap 1: Toon het menu (spel spelen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("    1) Speel het spel \n    2) Afsluiten");

                try
                {
                    // Stap 2: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());


                    // Scherm wissen
                    Console.Clear();

                    // Stap 3: als 1
                    if (_keuze == 1)
                    {
                        //    	Stap 4: maak een willekeurig getal
                        Random rdm = new Random();
                        Byte geheimgetal = Convert.ToByte(rdm.Next(1, 101));
                        bool gevonden = false;

                        //    	Stap 5: Geef de gebruiker 7 kansen
                        for (int i = _aantalKansen; i > 0; i--)
                        {
                            // Scherm wissen
                            Console.Clear();

                            try
                            {
                                //     o   Stap 6: Vraag de gokpoging van de gebruiker
                                Console.WriteLine($"U heeft nog {i.ToString()} kansen.");
                                Console.Write("\nDoe een gok naar het geheime getal: ");
                                Byte raadkans = Byte.Parse(Console.ReadLine());


                                // Scherm wissen
                                Console.Clear();

                                //         o Stap 7: kijk of de gok juist is
                                //                  -Als de gok kleiner is:
                                if (raadkans < geheimgetal)
                                {
                                    //                       Stap 8: Zeg het te raden getal is hoger
                                    Console.WriteLine("Sorry maar het te raden getal is hoger.");
                                    
                                }
                                //                   Als de gok hoger is:
                                else if (raadkans > geheimgetal)
                                {
                                    //				         Stap 9: Zeg het te raden getal is lager
                                    Console.WriteLine("Sorry, maar het te raden getal is lager.");
                                }
                                //                   Als gok juist is:
                                else
                                {
                                    //				         Stap 10: Zeg proficiat +stop lus
                                    Console.WriteLine($"Feest! yeee! Je hebt het getal geraden in {(_aantalKansen + 1 - i).ToString()} beurten.");
                                    Console.WriteLine("\nGa alsjeblieft nu iets nuttig doen met uw leven.");
                                    gevonden = true;
                                    
                                }

                                // Ga na of het getal gevonden is
                                if (gevonden)
                                {
                                    Console.WriteLine("\nDruk op enter om terug te keren naar het menu.");
                                    Console.ReadKey();

                                    // Stop de lus
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        Console.WriteLine("Jammer, maar jouw kansen zijn op, en je hebt het getal niet gevonden.");
                                        Console.WriteLine($"Het getal dat je zocht was: {geheimgetal.ToString()}.");
                                        Console.WriteLine("\nDruk op enter om terug te keren naar het menu.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nDruk op enter om nog eens te proberen.");
                                    }
                                }
                                Console.ReadKey();
                            }
                            catch
                            {
                                // Scherm wissen
                                Console.Clear();

                                // Foutmelding
                                Console.WriteLine("U gaf geen getal in.");
                                Console.WriteLine("Druk op enter om opnieuw te proberen.");
                                Console.ReadKey();

                                // Zorg dat het aantal kansen behouden blijft
                                i++;
                            }
                        }
                        //                   Als de kansen op zijn:
                        //				         Stap 11: Zeg de kansen zijn op en toon het getal
                        //            Als de gok niet juist was en er nog raadkansen over zijn, keer terug naar stap 5
                    }
                    // Als 2:
                    else if (_keuze == 2)
                    {
                        //      Stap 12: Toon afsluittekst
                        // Scherm wissen
                        Console.Clear();
                    }
                    // in elk ander geval
                    else
                    {
                        // Scherm wissen
                        Console.Clear();

                        // Foutmelding
                        Console.WriteLine("U gaf geen getal in.");
                        Console.WriteLine("\nDruk op een knop om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen geldige keuze in.");
                    Console.WriteLine("\nDruk op een knop om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
                //            Stap 13: Als de keuze niet 2 is, keer terug naar stap
            } while (_keuze != 2);
        }
    }
}
