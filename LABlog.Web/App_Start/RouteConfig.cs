using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LABlog.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Posts",
                url: "posts",
                defaults: new { controller = "Posts", action = "Index" }
            );

            routes.MapRoute(
                name: "SinglePost",
                url: "posts/{slug}",
                defaults: new { controller = "Posts", action = "Single", slug = ""}
            );

            routes.MapRoute(
                name: "Posts Admin",
                url: "admin/posts/{action}",
                defaults: new { controller = "Admin", action = "CreatePost" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
