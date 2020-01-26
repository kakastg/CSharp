using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DyskusjaSR.Models
{
    public class NaszeDane
    {
        public int ID { get; set; }
        public string NazwaBanku { get; set; }
        public int KapitałPoczątkowy { get; set; }
        public DateTime DataRozpoczęcia { get; set; }
        public double Oprocentowanie { get; set; }
        public double Zysk { get; set; }
    }
}