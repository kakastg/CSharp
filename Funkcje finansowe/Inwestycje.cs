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
            if (kwotaPoczatkowa > 0 && kwotaKoncowa>0)
                return Math.Round(kwotaKoncowa / kwotaPoczatkowa - 1,6);
            else
                throw new ArithmeticException("Dzielenie przez zero!!!!");
        }

        public double oprocentowanieSkladane(double kwotaPoczatkowa, double kwotaKoncowa, double oprocentowanie, int okres, int kapitalizacja)
        {
            throw new NotImplementedException();
        }
    }
}
