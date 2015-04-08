using LABlog.Web.DependencyResolution;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LABlog.Web.Bootstrap
{
    public class StructureMapBootstrapper
    {
        public static void Bootstrap()
        {
            new StructureMapBootstrapper().Start();
        }

        private void Start()
        {
            IContainer container = IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
        }
    }
}