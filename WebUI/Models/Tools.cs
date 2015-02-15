using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class Tools
    {
        //Create Folder and File in Views
        public static void AutoGenView(string MapPath)
        {
            string page_name = PageName("", "\\");
            string file_path = MapPath + "Views\\" + page_name + ".cshtml";
            string dir_name = System.IO.Path.GetDirectoryName(file_path);
            string file_name = System.IO.Path.GetFileName(file_path);

            if (!System.IO.Directory.Exists(dir_name))
            {
                System.IO.Directory.CreateDirectory(dir_name);
            }

            if (!System.IO.File.Exists(file_path) ) { 
                System.IO.File.WriteAllText(file_path, page_name + @"<br /><a href=""javascript:history.go(-1)"" class=""btn btn-secondary"">Back Home</a>");
            }
        }

        //Get Controller name and Action name from current Controller
        public static string PageName()
        {
            return PageName("");
        }
        public static string PageName(string action, string comma = "_")
        {
            HttpContextWrapper httpContext = new HttpContextWrapper(System.Web.HttpContext.Current);
            var routeData = System.Web.Routing.RouteTable.Routes.GetRouteData(httpContext);
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            string Page = Convert.ToString(controllerName);
            string Action = Convert.ToString(actionName);

            return Page + comma + Action;
        }
    }
}