using LABlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABlog.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
            :base("LABlogDb")
        {

        }

        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Category> Categories { get; set; }
    }
}
