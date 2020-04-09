using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Product
{
    public class CreateProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
