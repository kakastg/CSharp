using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aukcje.Models
{
    public class Aukcja
    {
        public static int liczbaAukcji = 0;
        public int aukcjaID { get; set; }
        public String przedmiot { get; set; }
        public decimal cenaWywolawcza { get; set; }
        public List<decimal> ceny { get; set; }
        public DateTime dataStart { get; set; }
        public DateTime dataZakonczenia { get; set; }
        public String sprzedajacy { get; set; }
        public String status { get; set; }

        public Aukcja(String przedmiot, decimal cenaWywolawcza,String sprzedajacy, int czasTrwania)
        {
            this.aukcjaID = liczbaAukcji++;
            this.przedmiot = przedmiot;
            this.cenaWywolawcza = cenaWywolawcza;
            this.ceny = new List<decimal>();
            this.dataStart = DateTime.Now;
            this.dataZakonczenia = DateTime.Now.AddDays(czasTrwania);
            this.sprzedajacy = sprzedajacy;
            this.status = "aktywna";

        }
        
    }
}