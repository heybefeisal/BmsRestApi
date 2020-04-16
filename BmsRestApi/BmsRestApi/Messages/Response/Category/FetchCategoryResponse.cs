﻿using BmsRestApi.Messages.DataTransferObjects.Product;
using System.Collections.Generic;

namespace BmsRestApi.Messages.Response.Category
{
    public class FetchCategoryResponse : ResponseBase
    {
        public int CategoriesPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; } 
    }
}
