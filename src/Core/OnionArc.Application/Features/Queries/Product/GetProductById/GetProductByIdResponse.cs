using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.GetProductById
{
    public class GetProductByIdResponse
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Sale { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }

    }
}
