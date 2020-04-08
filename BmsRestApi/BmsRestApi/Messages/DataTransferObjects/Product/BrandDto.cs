﻿using BmsRestApi.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Messages.DataTransferObjects.Product
{
    public class BrandDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }

        public BrandStatus BrandStatus { get; set; }
    }
}