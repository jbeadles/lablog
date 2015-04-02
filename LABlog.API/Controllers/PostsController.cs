using LABlog.Core.Entities;
using LABlog.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LABlog.API.Controllers
{
    public class PostsController : ApiController
    {
        private PostRepository _postRepository = new PostRepository();

        public IHttpActionResult GetPosts()
        {
            List<Post> posts = _postRepository.GetAll();
            return Ok(posts);
        }

        public IHttpActionResult GetPost(int id) 
        {
            Post post = _postRepository.Find(id);
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        public IHttpActionResult CreatePost(Post post)
        {
            post.Abstract = post.Body.Substring(0, 250);
            post.Created = DateTime.Now;
            post.PostedBy = "LA Beadles";
            _postRepository.Create(post);
            return Ok(post);
        }

        public IHttpActionResult UpdatePost(int id, Post post)
        {
            Post postToUpdate = _postRepository.Find(id);
            if (postToUpdate == null)
            {
                return NotFound();
            }

            post.Abstract = post.Body.Substring(0, 250);
            _postRepository.Update(post);
            return Ok(post);
        }

        public IHttpActionResult DeletePost(int id)
        {
            Post post = _postRepository.Find(id);
            if (post == null)
            {
                return NotFound();
            }

            _postRepository.Delete(id);
            return Ok(post);
        }
    }
}
