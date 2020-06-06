using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscussionForum.Controllers
{
    public class HomeController : Controller
    {
        
        public String Index()
        {
            return "Go to Hell";
        }
        public String Index1()
        {
            return "BHdrajmmasnjabs";
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
    }
}