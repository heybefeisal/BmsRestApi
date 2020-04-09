namespace BmsRestApi.Messages.Request.Category
{
    public class FetchCategoriesRequest
    {
        public int PageNumber { get; set; }
        public int CategoryPerPage { get; set; }
    }
}
