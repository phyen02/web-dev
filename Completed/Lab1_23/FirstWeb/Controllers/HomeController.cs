using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "Welcome to website";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.message = "About page";
            return View();
        }
    }
}