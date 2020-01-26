using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWeb.Models
{
    public class DaneGierContext : DbContext
    {
        public DaneGierContext() : base("connectionString")
        {

        }
        public DbSet<DaneGier> DaneGier { get; set; }

    }
}