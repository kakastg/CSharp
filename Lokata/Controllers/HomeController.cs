using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DyskusjaSR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kalkulator()
        {
            return View();
        } 
        public ActionResult DyskusjaNick()
        {
            return View();
        }
    }
}