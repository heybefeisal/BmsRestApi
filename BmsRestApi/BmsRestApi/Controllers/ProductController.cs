using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BmsRestApi.Messages.Request.Product;
using BmsRestApi.Messages.Response.Product;
using BmsRestApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BmsRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(template:"{id}")] // get product by id
        public ActionResult<GetProductResponse> GetProduct(long id)
        {
            var getProductRequest = new GetProductRequest
            {
                Id = id
            };
            var getProductResponse = _productService.GetProduct(getProductRequest);
            return getProductResponse;
        }

        [HttpGet()] // get all products
        public ActionResult<FetchProductResponse> GetProducts()
        {
            var fetchProductRequest = new FetchProductsRequest { };
            var fetchProductResponse = _productService.GetProducts(fetchProductRequest);
            return fetchProductResponse;
        }

        [HttpPost()] // create a product
        public ActionResult<CreateProductResponse> CreateProduct(CreateProductRequest createProductRequest)
        {
            var createProductResponse = _productService.SaveProduct(createProductRequest);
            return createProductResponse;
        }

        [HttpPut()] // edit a product
        public ActionResult<UpdateProductResponse> UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var updateProductResponse = _productService.EditProduct(updateProductRequest);
            return updateProductResponse;
        }

        [HttpDelete()] // delete a product
        public ActionResult<DeleteProductResponse> DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var deleteProductResponse = _productService.DeleteProduct(deleteProductRequest);
            return deleteProductResponse;
        }


    }
}