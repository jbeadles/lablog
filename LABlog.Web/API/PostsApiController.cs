using LABlog.Data.Repositories;
using LABlog.Web.Data.Repositories;
using LABlog.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LABlog.API.Controllers
{
    public class PostsApiController : ApiController
    {
        private readonly IPostRepository _postRepository;

        public PostsApiController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IHttpActionResult GetPosts()
        {
            List<Post> posts = _postRepository.GetAllPosts();
            return Ok(posts);
        }

        public IHttpActionResult GetPost(int id) 
        {
            Post post = _postRepository.FindPostById(id);
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
            _postRepository.CreatePost(post);
            return Ok(post);
        }

        public IHttpActionResult UpdatePost(int id, Post post)
        {
            Post postToUpdate = _postRepository.FindPostById(id);
            if (postToUpdate == null)
            {
                return NotFound();
            }

            post.Abstract = post.Body.Substring(0, 250);
            _postRepository.UpdatePost(post);
            return Ok(post);
        }

        public IHttpActionResult DeletePost(int id)
        {
            Post post = _postRepository.FindPostById(id);
            if (post == null)
            {
                return NotFound();
            }

            _postRepository.DeletePost(id);
            return Ok(post);
        }
    }
}
