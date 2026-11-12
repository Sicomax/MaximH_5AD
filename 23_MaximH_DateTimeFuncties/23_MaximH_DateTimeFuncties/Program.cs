using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MaximH_DateTimeFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maxim Heyndrickx
            // 12/11/2026
            // Project Toon Datum

            // Velden
            DateTime _datum = DateTime.MinValue;


            // Programma

            // Stap 1: Neem de datum van vandaag + toon op het scherm
            _datum = DateTime.Now;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Neem enkel de datum en niet de tijd
            _datum = DateTime.Today;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            _datum = DateTime.Now.Date;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Jaar van de huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"Het jaar van vandaag: {_datum.Year.ToString()}\n");

            // dag van de huidige datum
            
            Console.WriteLine($"De dag van vandaag: {_datum.Day.ToString()}\n");

            // Uur van de huidige datum
            
            Console.WriteLine($"Het uur van vandaag: {_datum.Hour.ToString()}\n");

            // Dag van de week
            Console.WriteLine($"Het uur van vandaag is {_datum.DayOfWeek.ToString()}\n");
            int uitkomst = Convert.ToInt32(_datum.DayOfWeek);
            Console.WriteLine($"{uitkomst.ToString()} \n");

            // Toevoegen van jaren, maanden, dagen, uren, minuten, seconden ...
            _datum = _datum.AddYears(1).AddDays(4).AddHours(2);
            Console.WriteLine($"Het uur van vandaag is {_datum.ToString()}\n");
            _datum = _datum.AddYears(-1).AddDays(-4).AddHours(-2);
            Console.WriteLine($"Het uur van vandaag is {_datum.ToString()}\n");

            // De verschillende ToString mogelijkheden
            Console.WriteLine("Hier zien we de verschillende tostring opties: \n");
            Console.WriteLine($"De normale ToString: {_datum.ToString()}\n");
            Console.WriteLine($"De ToLongDateString: {_datum.ToLongDateString()}\n");
            Console.WriteLine($"De Long Date: {_datum.ToLongTimeString()}\n");
            Console.WriteLine($"De Short Date: {_datum.ToShortDateString()}\n");
            Console.WriteLine($"De Short Time: {_datum.ToShortTimeString()}\n");

            // Rekenen met datums
            DateTime datum2 = DateTime.Now.AddYears(3);

            // Rechtstreeks rekenen met datums gaat niet!!
            //_datum = datum2 - _datum;

            // Je moet een variabele gebruiken van het datatype TimeSpan.
            TimeSpan verschil = datum2 - _datum;
            Console.WriteLine($"{verschil.ToString()}");
        }
    }
}
