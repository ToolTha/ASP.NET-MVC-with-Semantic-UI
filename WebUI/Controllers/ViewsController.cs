using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ViewsController : Controller
    {
        // GET: 
        [Route("view")]
        public ActionResult Index()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Advertisement
        public ActionResult Advertisement()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Card
        public ActionResult Card()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Comment
        public ActionResult Comment()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Feed
        public ActionResult Feed()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Item
        public ActionResult Item()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
        // GET: Statistic
        public ActionResult Statistic()
        {
            Tools.AutoGenView(Server.MapPath("~/"));
            return View();
        }
    }
}