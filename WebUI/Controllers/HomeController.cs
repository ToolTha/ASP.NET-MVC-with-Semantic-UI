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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Force Create Database
        public ActionResult CreateDatabase()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.Initialize(true);

            return View();
        }

        //Drop Database (Delete Database file)
        public ActionResult DropDatabase()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.Delete();

            return View();
        }
    }
}