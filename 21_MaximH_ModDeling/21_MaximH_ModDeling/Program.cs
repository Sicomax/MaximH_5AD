using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MaximH_ModDeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maxim Heyndrickx
            // 12/11/26
            // Project ModDeling

            // Velden
            const double _deler = 7;
            const double _deeltal = 29;

            // Programma
            Console.WriteLine("Deel 29 / 7");
            Console.WriteLine($"De uitkomst van de deling: {(_deeltal / _deler).ToString()}");
            Console.WriteLine($"De uitkomst afgerond van de deling: {(Math.Round(_deeltal / _deler,2)).ToString()} \n");
            Console.WriteLine($"7 gaat {(Math.Floor(_deeltal / _deler)).ToString()} in 29");
            Console.WriteLine($"De modulaire deling: {(_deeltal % _deler).ToString()}");

        }
    }
}
