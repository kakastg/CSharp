using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aukcje.Models;

namespace Aukcje.Controllers
{
    public class AukcjeController : Controller
    {
        // GET: Aukcje
        public ActionResult Index(String nazwa)
        {
            List<Aukcja> aukcje = new List<Aukcja>()
            {
                new Aukcja("Latarka", 12.99m, "Szef wszystkich szefów", 7),
                new Aukcja("Młotek", 8, "Jan III Sobieski", 14),
                new Aukcja("Turbomotopompka", 99.99m, "Krzysztof Jarzyna", 7)
            };
            aukcje[1].status = Status.anulowana;

            if (!String.IsNullOrEmpty(nazwa))
            {
                for(int i = 0; i < aukcje.Count; i++)
                {
                    if (aukcje[i].przedmiot.Contains(nazwa))
                    {
                        aukcje.RemoveAt(i--);
                    }
                }
            }
            return View(aukcje);
        }
    }
}