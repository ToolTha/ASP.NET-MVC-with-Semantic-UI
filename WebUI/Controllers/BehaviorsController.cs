using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class BehaviorsController : Controller
    {
        // GET: Behaviors
        public ActionResult Index()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Api
        public ActionResult Api()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Form Validation
        public ActionResult Form()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
    }
}