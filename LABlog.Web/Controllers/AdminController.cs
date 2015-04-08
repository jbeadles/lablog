using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABlog.Web.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Login
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // GET: Admin/Posts/New
        public ActionResult New()
        {
            return View("~/Views/Admin/Posts/New.cshtml");
        }
        
    }
}