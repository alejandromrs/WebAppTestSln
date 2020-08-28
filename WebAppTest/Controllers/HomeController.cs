using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. Change over here";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello world";

            return View();
        }
    }
}