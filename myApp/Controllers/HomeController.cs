using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            ViewData["Name"] = "Home Screen";
            ViewBag.country = new List<string>() {"india","china","aus" };
            return View();
        }

    }
}
