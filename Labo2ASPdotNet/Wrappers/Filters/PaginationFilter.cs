using System;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Wrappers.Filters
{
    public class PaginationFilter
    {
        [FromQuery(Name = "PageNumber")]
        public int PageNumber { get; set; }

        [FromQuery(Name = "PageSize")]
        public int PageSize { get; set; }
        public PaginationFilter()
        {
            PageNumber = 1;
            PageSize = 20;
        }
        public PaginationFilter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 20 ? 20 : pageSize;
        }
    }
}
