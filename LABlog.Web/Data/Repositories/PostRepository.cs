using LABlog.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using System.Text.RegularExpressions;
using LABlog.Web.Models;
using LABlog.Web.Data.Repositories;
using LABlog.Web.Helpers;

namespace LABlog.Data.Repositories
{
    public class PostRepository : IPostRepository
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

        public List<Post> GetAllPosts()
        {
            return _db.Fetch<Post>("WHERE Published = @0", true);
        }

        public Post FindPostById(int id)
        {
            return _db.SingleOrDefault<Post>("WHERE Id = @0", id);
        }

        public Post CreatePost(Post post)
        {
            post.Slug = StringHelpers.ToSlug(post.Title);
            _db.Insert(post);
            return post;
        }

        public Post UpdatePost(Post post)
        {
            post.Slug = StringHelpers.ToSlug(post.Title);
            _db.Update(post);
            return post;
        }

        public void DeletePost(int id)
        {
            _db.Delete<Post>("WHERE Id = @", id);
        }
    }
}
