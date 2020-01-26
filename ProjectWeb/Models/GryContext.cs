using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectWeb.Models
{
    public class GryContext : DbContext
    {
        public GryContext() : base("connectionString")
        {

        }
        public DbSet<Gry> gry { get; set; }

    }
}