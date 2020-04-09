namespace BmsRestApi.Messages.Request.Brand
{
    public class FetchBrandsRequest
    {
        public int PageNumber { get; set; }
        public int BrandPerPage { get; set; }
    }
}
