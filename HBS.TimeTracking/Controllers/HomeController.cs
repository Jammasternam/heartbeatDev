﻿using System.Web.Mvc;

namespace HBS.TimeTracking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return RedirectToAction("Daily", "TimeTrack");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}