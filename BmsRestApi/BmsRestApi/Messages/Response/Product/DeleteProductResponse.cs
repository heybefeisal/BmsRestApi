using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Product
{
    public class DeleteProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
