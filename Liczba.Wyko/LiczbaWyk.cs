using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba.Wyko
{
    class LiczbaWyk
    {
        static void Main(string[] args)
        {
            var liczba = new Liczba();
            String input = Console.ReadLine();
            while (!Int32.TryParse(input, out int number))
            {
                Console.WriteLine("Oops...Błąd");
                Environment.Exit(0);
            }
            String output = liczba.IntToRoman(Convert.ToInt32(input));
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
