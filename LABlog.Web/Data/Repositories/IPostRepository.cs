using LABlog.Data.Repositories;
using LABlog.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABlog.Web.Data.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post FindPostById(int id);
        Post CreatePost(Post post);
        Post UpdatePost(Post post);
        void DeletePost(int id);
    }
}
