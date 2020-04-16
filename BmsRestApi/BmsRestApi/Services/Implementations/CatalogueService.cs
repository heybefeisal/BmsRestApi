using BmsRestApi.Messages;
using BmsRestApi.Messages.Request.Product;
using BmsRestApi.Messages.Response.Product;
using BmsRestApi.Models.Product;
using BmsRestApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BmsRestApi.Services.Implementations
{
    public class CatalogueService : ICatalogueService
    {
        private IProductRepository _productRepository;
        private MessageMapper _messageMapper;

        public CatalogueService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _messageMapper = new MessageMapper();
        }
        public FetchProductResponse FetchProducts(FetchProductsRequest fetchProductsRequest)
        {

            IEnumerable<Product> products = new List<Product>();

            int productCount = 0;

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                productCount = _productRepository.GetAllProducts().Count();
                products = _productRepository.GetAllProducts()
                   .Where(product => product.ProductStatus == ProductStatus.Active)
                   .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                   .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category.Slug == fetchProductsRequest.CategorySlug &&
                                                                           product.Brand.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category.Slug == fetchProductsRequest.CategorySlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Brand.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            var totalPages = (int)Math.Ceiling((decimal)productCount / fetchProductsRequest.ProductsPerPage);

            int[] pages = Enumerable.Range(1, totalPages).ToArray();

            var productDtos = _messageMapper.MapToProductDto(products);

            var fetchProductsResponse = new FetchProductResponse()
            {
                ProductsPerPage = fetchProductsRequest.ProductsPerPage,
                Products = productDtos,
                HasPreviousPages = (fetchProductsRequest.PageNumber > 1),
                CurrentPage = fetchProductsRequest.PageNumber,
                HasNextPages = (fetchProductsRequest.PageNumber < totalPages),
                Pages = pages
            };

            return fetchProductsResponse;
        }
    }
}
