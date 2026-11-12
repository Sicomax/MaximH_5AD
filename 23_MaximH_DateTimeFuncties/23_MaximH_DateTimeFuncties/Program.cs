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
            _datum = DateTime.Now;
            Console.WriteLine($"De dag van vandaag: {_datum.Day.ToString()}\n");

            // Uur van de huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"Het uur van vandaag: {_datum.Hour.ToString()}\n");
        }
    }
}
