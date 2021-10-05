using OnionArc.Application.Features.Queries.GetAllProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.Category.GetAllCategories
{
    public class GetAllCategoryQueryResponse
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public GetAllCategoryQueryResponse Parent { get; set; }
        public List<GetAllCategoryQueryResponse> Categories { get; set; }
        public List<GetAllProductQueryResponse> Products { get; set; }
    }
}
