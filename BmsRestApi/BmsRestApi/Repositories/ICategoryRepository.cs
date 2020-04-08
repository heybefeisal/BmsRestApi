using BmsRestApi.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Repositories
{
    public interface ICategoryRepository
    {
        Category FindCategoryById(long id);

        IEnumerable<Category> GetAllCategories();
        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
     }
}
