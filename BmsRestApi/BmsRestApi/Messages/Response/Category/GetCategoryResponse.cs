using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Category
{
    public class GetCategoryResponse : ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
