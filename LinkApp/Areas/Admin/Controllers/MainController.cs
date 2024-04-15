using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trupic.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        // GET: Admin/Main
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Earnings()
        {
            return View();
        }

        
        public ActionResult Posts()
        {
            return View();
        }
        public ActionResult Detail(string Id)
        {
            return View();
        }
    }
}