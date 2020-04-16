using BmsRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public ProductDto Products { get; set; }
    }
}
