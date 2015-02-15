using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class GlobalsController : Controller
    {
        // GET: Globals
        public ActionResult Index()
        {
            Tools.AutoGenView( Server.MapPath("~/"));
            return View();
        }
        // GET: Reset
        public ActionResult Reset()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Site
        public ActionResult Site()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
    }
}