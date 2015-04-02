using LABlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace LABlog.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private Database _db;

        public CategoryRepository()
        {
            _db = new Database("LABlogDb");
        }

        public CategoryRepository(Database db)
        {
            _db = db;
        }

        public List<Category> GetAll()
        {
            return _db.Fetch<Category>("");
        }

        public Category Find(int id)
        {
            return _db.SingleOrDefault<Category>("WHERE Id = @0", id);
        }

        public List<Post> FindPosts(int id)
        {
            return _db.Query<Post>("WHERE CategoryId = @0", id).ToList();
        }

        public Category Create(Category category)
        {
            _db.Insert(category);
            return category;
        }

        public Category Update(Category category)
        {
            _db.Update(category);
            return category;
        }

        public void Delete(int id)
        {
            _db.Delete<Category>("WHERE Id = @0", id);
        }
    }
}
