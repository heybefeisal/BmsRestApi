namespace BmsRestApi.Messages.Request.Product
{
    public class FetchProductsRequest
    {
        public int PageNumber { get; set; }
        public int ProductPerPage { get; set; }
        public string CategorySlug { get; set; }
        public string BrandSlug { get; set; }
    }
}
