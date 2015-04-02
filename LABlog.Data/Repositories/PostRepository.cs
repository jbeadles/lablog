using LABlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace LABlog.Data.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private Database _db;

        public PostRepository()
        {
            _db = new Database("LABlogDb");
        }

        public PostRepository(Database db)
        {
            _db = db;
        }

        public List<Post> GetAll()
        {
            return _db.Fetch<Post>("WHERE Published = @0", true);
        }

        public Post Find(int id)
        {
            return _db.SingleOrDefault<Post>("WHERE Id = @0", id);
        }

        public Post Create(Post post)
        {
            _db.Insert(post);
            return post;
        }

        public Post Update(Post post)
        {
            _db.Update(post);
            return post;
        }

        public void Delete(int id)
        {
            _db.Delete<Post>("WHERE Id = @", id);
        }
    }
}
