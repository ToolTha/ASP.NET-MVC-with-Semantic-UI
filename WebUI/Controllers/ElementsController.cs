using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ElementsController : Controller
    {
        // GET: Elements
        public ActionResult Index()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Button
        public ActionResult Button()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Divider
        public ActionResult Divider()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Flag
        public ActionResult Flag()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Header
        public ActionResult Header()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Icon
        public ActionResult Icon()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Image
        public ActionResult Image()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Input
        public ActionResult Input()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Label
        public ActionResult Label()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: List
        public ActionResult List()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Loader
        public ActionResult Loader()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Rail
        public ActionResult Rail()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Reveal
        public ActionResult Reveal()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Segment
        public ActionResult Segment()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Step
        public ActionResult Step()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
    }
}