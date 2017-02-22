using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() // the first container 
        {
            return View();
        }

        public ActionResult Contact() // the second container 
        {
            return View();
        }

        public ActionResult Project() // the first container 
        {
            return View();
        }



    }
}