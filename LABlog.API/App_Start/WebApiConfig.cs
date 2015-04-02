using LABlog.API.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace LABlog.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var jsonFormatter = new JsonMediaTypeFormatter();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
