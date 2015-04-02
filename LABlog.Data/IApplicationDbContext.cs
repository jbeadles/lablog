using LABlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABlog.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<Post> Posts { get; set; }
        IDbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
