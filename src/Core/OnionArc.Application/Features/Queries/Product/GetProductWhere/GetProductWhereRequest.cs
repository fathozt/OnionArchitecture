using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.GetProductWhere
{
    public class GetProductWhereRequest : IRequest<List<GetProductWhereResponse>>
    {
        public string Name { get; set; }
    }
}
