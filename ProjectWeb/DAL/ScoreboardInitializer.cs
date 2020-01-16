using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjectWeb.Models;
using ProjectForm;
using System.Data.Entity.Validation;

namespace ProjectWeb.DAL
{
    public class ScoreboardInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ScoreContext>
    {
        protected override void Seed(ScoreContext context)
        {
            
            try
            {
                var forma = new Form1();
                var scoring = new List<Score>
            {
            new Score{playerID = 1,login = forma.login, points=forma.points, seconds= forma.seconds, ClientIp="127.0.0.1"},
            };

                scoring.ForEach(s => context.Wyniki.Add(s));
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            context.SaveChanges();
        }
    }
}