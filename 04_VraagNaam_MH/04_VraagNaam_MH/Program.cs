using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VraagNaam_MH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Maxim Heyndrickx
            Project: Hallo naam
            22/09/2026
            */
            //velden
            String _naamGebruiker = null;
            String _bewerking = null;


            //Programma
            // Stap 1: Vraag naam +opslaan
            Console.Write("Geef uw naam: ");
            _naamGebruiker = Console.ReadLine();
            // Stap 2: Maak de juiste tekst
            //_bewerking = "Hallo {0} " + _naamGebruiker;
            // _bewerking = String.Format("hallo {0}", _naamGebruiker;
            _bewerking = $"Hallo {_naamGebruiker}";

            // Scherm wissen
            Console.Clear();

            // Stap 3: Toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);
        }
    }
}
