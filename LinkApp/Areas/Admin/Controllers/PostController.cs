using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trupic.Areas.Admin.Controllers
{
    
    public class PostController : Controller
    {
        // GET: Admin/Events
     
        public ActionResult Category()
        {
            return View();
        }

      
        public ActionResult ReportedEvents()
        {
            return View();
        }
        public ActionResult instaData()
        {
            return View();
        }

        public ActionResult Design()
        {
            return View();
        }

        public ActionResult Fonts()
        {
            return View();
        }
    }
}