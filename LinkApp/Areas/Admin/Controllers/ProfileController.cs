﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trupic.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        public ActionResult AdminProfile()
        {
            return View();
        }
    }
}