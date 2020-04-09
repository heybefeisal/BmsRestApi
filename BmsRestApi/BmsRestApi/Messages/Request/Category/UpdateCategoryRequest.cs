using BmsRestApi.Messages.DataTransferObjects.Product;

namespace BmsRestApi.Messages.Request.Category
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        public CategoryDto Brand { get; set; }
    }
}
