using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Brand
{
    public class CreateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
     }
}
