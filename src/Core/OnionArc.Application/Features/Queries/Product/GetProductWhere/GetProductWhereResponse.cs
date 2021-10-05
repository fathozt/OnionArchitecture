using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.GetProductWhere
{
    public class GetProductWhereResponse
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Sale { get; set; }
        public string CategoryName { get; set; }
    }
}
