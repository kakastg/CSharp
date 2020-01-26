using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DyskusjaSR.Models
{
    public class NaszeDaneContext : DbContext
    {
        public NaszeDaneContext() : base("connectionString")
        {

        }
        public DbSet<NaszeDane> NaszeDane { get; set; }
    }
}