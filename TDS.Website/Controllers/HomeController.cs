using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDS.Website.Models;

namespace TDS.Website.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new HomeViewModel();
            model.Name = "Steen";

            return View(model);
        }

        [HttpPost]
        public ActionResult About(HomeViewModel model)
        {
            model.Name += " YAY!";
            return View(model);
        }

        [HttpPost]
        public string Stuff(string name)
        {
            return "STUFF!!!";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}