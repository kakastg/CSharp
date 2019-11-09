using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba
{
    public class Liczba
    {
        private static int[] arabskie = { 1000, 500, 100, 50, 10, 5, 1 };
        private static char[] rzymskie = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

        public String IntToRoman(int number)
        {
            int i = 0;
            String wynik = "";
            if (number < 4000 && number > 1)
            {
                while (number > 0 && i < arabskie.Length)
                {
                    if (number >= arabskie[i])
                    {
                        number -= arabskie[i];
                        wynik += rzymskie[i];
                    }
                    else if ((i % 2 == 0) &&
                    (i < arabskie.Length - 2) &&
                    (number >= arabskie[i] - arabskie[i + 2]) &&
                    (arabskie[i + 2] != arabskie[i] - arabskie[i + 2]))
                    {
                        number -= arabskie[i] - arabskie[i + 2];
                        wynik += rzymskie[i + 2];
                        wynik += rzymskie[i];
                        i++;
                    }
                    else if ((i % 2 == 1) &&
                    (i < arabskie.Length - 1) &&
                    (number >= arabskie[i] - arabskie[i + 1]) &&
                    (arabskie[i + 1] != arabskie[i] - arabskie[i + 1]))
                    {
                        number -= arabskie[i] - arabskie[i + 1];
                        wynik += rzymskie[i + 1];
                        wynik += rzymskie[i];
                        i++;
                    }
                    else
                        i++;
                }
                return wynik;
            }
            else
                throw new ArithmeticException("Parametr poza zakresem");
        }
    }
}
