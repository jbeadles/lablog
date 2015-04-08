using LABlog.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABlog.Web.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<Post> Posts { get; set; }
        IDbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
