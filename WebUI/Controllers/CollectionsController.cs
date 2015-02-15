using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CollectionsController : Controller
    {
        // GET: Modules
        public ActionResult Index()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Breadcrumb
        public ActionResult Breadcrumb()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Form
        public ActionResult Form()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Grid
        public ActionResult Grid()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Menu
        public ActionResult Menu()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Message
        public ActionResult Message()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Table
        public ActionResult Table()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
    }
}