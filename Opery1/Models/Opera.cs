using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Opery1.Models
{
    public class OperyDB : DbContext
    {
        public DbSet<Opera> opery { get; set; }
    }
    public class Opera
    {
        public int OperaId { get; set; }
        [Required]
        [StringLength(200)]
        public String Nazwa { get; set; }
        [SprawdzRok]
        public int Rok { get; set; }
        [Required]
        [StringLength(100)]
        public String Kompozytor { get; set; }

        private class SprawdzRokAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                int rok = (int)value;
                if (rok < 1598 || rok > DateTime.Now.Year)
                    return false;
                else
                    return true;
            }
        }
    }
}