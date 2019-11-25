using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR01.Controllers
{
    public class DyskusjaController : Controller
    {
        // GET: Dyskusja
        public ActionResult Dyskusja()
        {
            return View();
        }
        public ActionResult DyskusjaNick()
        {
            return View();
        }
    }
}