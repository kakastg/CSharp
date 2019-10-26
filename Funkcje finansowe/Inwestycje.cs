using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcjefinansowe
{
    public class Inwestycje
    {
        public double wartoscPrzyszla(double kwotaPoczatkowa, double oprocentowanie)
        {
            if (kwotaPoczatkowa > 0)
                return kwotaPoczatkowa * (1 + oprocentowanie);
            else
                throw new ArithmeticException("Kwota nie moze byc ujemna");
        }
        public double wyliczStope(double kwotaPoczatkowa, double kwotaKoncowa)
        {
            if (kwotaPoczatkowa == 0)
                throw new ArithmeticException("Dzielenie przez zero!!!!");
            else
                return Math.Round(kwotaKoncowa / kwotaPoczatkowa - 1, 6);
        }

        public double oprocentowanieSkladane(double kwotaPoczatkowa, double kwotaKoncowa, double oprocentowanie, double okres, double kapitalizacja)
        {
            double temp = 1;
            if (kwotaPoczatkowa > 0) {
                for (int i = 0; i < (okres*kapitalizacja); i++)
                {
                    temp *= (1 + (oprocentowanie/kapitalizacja));
                }
                return Math.Round((temp*kwotaPoczatkowa),2);
            }
            else
                throw new ArithmeticException("Dzielenie przez zero!!!!");


        }
    }
}