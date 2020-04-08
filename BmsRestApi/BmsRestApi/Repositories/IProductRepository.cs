using BmsRestApi.Models.Product;
using System.Collections.Generic;

namespace BmsRestApi.Repositories
{
    public interface IProductRepository
    {
        Product FindProductById(long id);
        IEnumerable<Product> GetAllProducts();

        void SaveProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
