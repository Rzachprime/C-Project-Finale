using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinale.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the page where you view your Army";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me!";

            return View();
        }
    }
}