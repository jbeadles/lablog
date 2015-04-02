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
    public class CategoriesController : ApiController
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();

        public IHttpActionResult GetCategories()
        {
            List<Category> categories = _categoryRepository.GetAll();
            return Ok(categories);
        }

        public IHttpActionResult GetCategory(int id) 
        {
            Category category = _categoryRepository.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        public IHttpActionResult GetPostsByCategory(int id)
        {
            List<Post> posts = _categoryRepository.FindPosts(id);
            if (posts == null)
            {
                return NotFound();
            }

            return Ok(posts);
        }

        public IHttpActionResult CreateCategory(Category category)
        {
            _categoryRepository.Create(category);
            return Ok(category);
        }

        public IHttpActionResult UpdateCategory(int id, Category category)
        {
            Category categoryToUpdate = _categoryRepository.Find(id);
            if (categoryToUpdate == null)
            {
                return NotFound();
            }

            _categoryRepository.Update(category);
            return Ok(category);
        }

        public IHttpActionResult DeleteCategory(int id)
        {
            Category category = _categoryRepository.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            _categoryRepository.Delete(id);
            return Ok(category);
        }
    }
}
