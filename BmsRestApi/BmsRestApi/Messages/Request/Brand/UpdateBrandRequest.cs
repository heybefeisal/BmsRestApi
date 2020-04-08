using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Request.Brand
{
    public class UpdateBrandRequest
    {
        public int Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}
