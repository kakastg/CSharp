using ProjectWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjectForm;
using System;

namespace ProjectWeb.DAL
{
    public class ScoreContext : DbContext
    {

        public ScoreContext() : base("ScoreContext")
        {
        }

        public DbSet<Score> Wyniki { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
       
    }
}