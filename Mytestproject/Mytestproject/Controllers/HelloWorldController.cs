﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View ();
        }

        //
        // Get: /HelloWorld/Welcome/

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;


            return View();
        }
    }
}
