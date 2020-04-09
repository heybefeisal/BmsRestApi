using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Response.Category
{
    public class DeleteCategoryResponse : ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
