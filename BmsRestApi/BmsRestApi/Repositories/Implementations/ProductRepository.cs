using BmsRestApi.Database;
using BmsRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private BmsDbContext _context;

        public ProductRepository(BmsDbContext context)
        {
            _context = context;
        }

        public Product FindProductById(long id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _context.Products
                .Include(navigationPropertyPath: p => p.Category)
                .Include(navigationPropertyPath: p => p.Brand);
            return products;
        }

        public void SaveProduct(Product  product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
