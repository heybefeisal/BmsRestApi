using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Product
{
    public class GetProductResponse : ResponseBase
    {
        public ProductDto Product{ get; set; }
    }
}
