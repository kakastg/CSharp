using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWeb.Models
{
    public class DaneGier
    {
        public int ID { get; set; }
        public String Nazwa { get; set; }
        public int RokWydania { get; set; }
        public String Wydawca { get; set; }
    }
}