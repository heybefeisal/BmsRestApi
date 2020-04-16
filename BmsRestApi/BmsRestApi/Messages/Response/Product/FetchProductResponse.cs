using BmsRestApi.Messages.DataTransferObjects.Product;
using System.Collections.Generic;

namespace BmsRestApi.Messages.Response.Product
{
    public class FetchProductResponse : ResponseBase
    {
        public int ProductsPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
