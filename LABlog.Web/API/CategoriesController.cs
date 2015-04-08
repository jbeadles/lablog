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
    public class CategoriesController : ApiController
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IHttpActionResult GetCategories()
        {
            List<Category> categories = _categoryRepository.GetAllCategories();
            return Ok(categories);
        }

        public IHttpActionResult GetCategory(int id) 
        {
            Category category = _categoryRepository.FindCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        public IHttpActionResult GetPostsByCategory(int categoryId)
        {
            List<Post> posts = _categoryRepository.GetPostsByCategory(categoryId);
            if (posts == null)
            {
                return NotFound();
            }

            return Ok(posts);
        }

        public IHttpActionResult CreateCategory(Category category)
        {
            _categoryRepository.CreateCategory(category);
            return Ok(category);
        }

        public IHttpActionResult UpdateCategory(int id, Category category)
        {
            Category categoryToUpdate = _categoryRepository.FindCategoryById(id);
            if (categoryToUpdate == null)
            {
                return NotFound();
            }

            _categoryRepository.UpdateCategory(category);
            return Ok(category);
        }

        public IHttpActionResult DeleteCategory(int id)
        {
            Category category = _categoryRepository.FindCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }

            _categoryRepository.DeleteCategory(id);
            return Ok(category);
        }
    }
}
