using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elegant_College.Controllers
{
    public class HomeController : Controller
    {
        //Action results for the user action at home page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Your course page";

            return View();
        }
    }
}