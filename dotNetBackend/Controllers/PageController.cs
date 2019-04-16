using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetBackend.Attributes;

namespace dotNetBackend.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        [Unauthorized(Roles = "PAGE_1")]
        public ActionResult Page_1()
        {
            ViewData["Page"] = "Page 1";
            return View("Index");
        }
        [Unauthorized(Roles = "PAGE_2")]
        public ActionResult Page_2()
        {
            ViewData["Page"] = "Page 2";
            return View("Index");
        }
        [Unauthorized(Roles = "PAGE_3")]
        public ActionResult Page_3()
        {
            ViewData["Page"] = "Page 3";
            return View("Index");
        }
    }
}