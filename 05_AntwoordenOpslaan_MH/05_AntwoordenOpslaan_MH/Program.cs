using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AntwoordenOpslaan_MH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Project favorieten
             * Maxim Heyndrickx
             * 29/09/2026
             */
            //velden
            String _favorieteKleur = null;
            String _favorieteDag = null;
            String _favorieteSeizoen = null;
            String _zin1 = null;
            String _zin2 = null;
            String _zin3 = null;

            //Programma
            //Stap 1: Vraag favoriete kleur + opslaan
            Console.WriteLine("Kies een kleur: ");
            _favorieteKleur = Console.ReadLine();

            //Scherm wissen
            Console.Clear();
            //Stap 2: Maak de juiste tekst +opslaan
            _zin1 = $"Je koos {_favorieteKleur}.";

            //Stap 3: Geef de gemaakte tekst weer
            Console.WriteLine(_zin1);
            Console.WriteLine("Druk op een toets om verder te gaan.");
            Console.ReadKey();

            //Scherm leegmaken
            Console.Clear();

            //Stap 4: Vraag favoriete dag + opslaan
            Console.WriteLine("Geef je favoriete week dag: ");
            _favorieteDag = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap 5: maak de juiste tekst +opslaan
            _zin2 = $"Je favoriete dag is {_favorieteDag}.";

            //Stap 6: Geef de gemaakte tekst weer
            Console.WriteLine(_zin2);
            Console.WriteLine("Druk op een toets om verder te gaan.");
            Console.ReadKey();

            //Scherm leegmaken
            Console.Clear();

            //Stap 7: Vraag favoriete seizoen + opslaan
            Console.WriteLine("Geef je favoriete seizoen: ");
            _favorieteSeizoen = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap 8: Maak de juiste tekst +opslaan
            _zin3 = $"Je favoriete seizoen is {_favorieteSeizoen}.";

            //Stap 9: Geef de gemaakte tekst weer
            Console.WriteLine(_zin3);
            Console.WriteLine("\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            //Scherm leegmaken
            Console.Clear();

        }
    }
}
