using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWeb.Models
{
    public class Gry
    {
        [Key]
        public int GryId { get; set; }
        [Required]
        [StringLength(100)]
        public String Nazwa { get; set; }
        [SprawdzRok]
        public int Rok { get; set; }
        public String Wydawca { get; set; }
        private class SprawdzRokAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                int rok = (int)value;
                if (rok < 1947 || rok > DateTime.Now.Year)
                    return false;
                else
                    return true;
            }
        }
    }
}