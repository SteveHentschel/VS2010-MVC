using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickRelational.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Simple test of two DB's, Books linked to Authors";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
