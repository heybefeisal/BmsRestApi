﻿using BmsRestApi.Models.Product;

namespace BmsRestApi.Messages.DataTransferObjects.Product
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }

        public CategoryStatus CategoryStatus { get; set; }
    }
}
