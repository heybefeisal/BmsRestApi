using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmsRestApi.Messages.Request.Brand
{
    public class FetchBrandsRequest
    {
        public int PageNumber { get; set; }
        public int BrandPerPage { get; set; }
    }
}
