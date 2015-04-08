using LABlog.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABlog.Web.Data.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category FindCategoryById(int id);
        Category CreateCategory(Category post);
        Category UpdateCategory(Category post);
        List<Post> GetPostsByCategory(int categoryId);
        void DeleteCategory(int id);
    }
}