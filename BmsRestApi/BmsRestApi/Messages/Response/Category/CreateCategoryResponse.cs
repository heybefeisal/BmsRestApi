using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Category
{
    public class CreateCategoryResponse : ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
