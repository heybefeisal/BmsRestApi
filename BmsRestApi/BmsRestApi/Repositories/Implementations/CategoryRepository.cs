using BmsRestApi.Database;
using BmsRestApi.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private BmsDbContext _context;

        public CategoryRepository(BmsDbContext context)
        {
            _context = context;
        }

        public Category FindCategoryById(long id)
        {
            var note = _context.Categories.Find(id);
            return note;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var notes = _context.Categories;
            return notes;
        }

        public void SaveCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
