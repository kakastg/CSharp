using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DyskusjaSR
{
    public class Liczenie
    {
        public double wynik(double a, double b)
        {
            // throw new NotImplementedException();
            if (a > 0 && b>0)
                return a * b;
            else
                throw new ArithmeticException("Kwota nie moze byc ujemna");
        }
        public double Zysk(double kapitalPoczotkowy, double oprocentowanie, int czas)
        {
            if (kapitalPoczotkowy > 0 && oprocentowanie>0 && czas>0)
                return kapitalPoczotkowy*oprocentowanie*czas;
            else
                throw new ArithmeticException("Kwota nie moze byc ujemna");
        }
    }
}