using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Brand
{
    public class DeleteBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
