using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABlog.Web.Bootstrap
{
    public class Bootstrapper
    {
        public static void Bootstrap()
        {
            new Bootstrapper().Start();
        }

        private void Start()
        {
            StructureMapBootstrapper.Bootstrap();
        }
    }
}