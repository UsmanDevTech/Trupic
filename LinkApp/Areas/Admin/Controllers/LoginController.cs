using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trupic.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult SignIn(string url)
        {
            ViewBag.urlRedirect = url;
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}