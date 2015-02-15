using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.Initialize(true);

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.Delete();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}