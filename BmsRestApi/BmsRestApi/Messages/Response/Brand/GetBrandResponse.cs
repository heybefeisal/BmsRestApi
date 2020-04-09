using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Brand
{
    public class GetBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
