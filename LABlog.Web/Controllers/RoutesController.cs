using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABlog.Web.Controllers
{
    public class RoutesController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            ViewBag.Page = "Home";
            return View();
        }

        // GET: /posts
        public ActionResult Posts()
        {
            ViewBag.Page = "Posts";
            return View();
        }

        // GET: /posts/:id
        public ActionResult Posts(int id)
        {
            return View("Post");
        }

        // GET: /login
        public ActionResult Login()
        {
            ViewBag.Page = "Login";
            return View();
        }

        // GET: /admin
        [Authorize]
        public ActionResult Admin()
        {
           
            ViewBag.Page = "Admin";
            return View();
        }

        public ActionResult AdminPosts()
        {
            ViewBag.Title = "Posts Admin";
            return View("AdminActions/Posts");
        }
    }
}