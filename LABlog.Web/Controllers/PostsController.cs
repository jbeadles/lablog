using LABlog.Web.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABlog.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET: Posts
        public ActionResult Index()
        {
            ViewBag.Page = "Posts";
            return View();
        }

        // GET: posts/:slug
        public ActionResult Single(string slug)
        {
            return View();
        }
    }
}