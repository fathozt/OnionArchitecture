using AutoMapper;
using MediatR;
using OnionArc.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.GetProductWhere
{
    public class GetProductWhereHandler : IRequestHandler<GetProductWhereRequest, List<GetProductWhereResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public GetProductWhereHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<GetProductWhereResponse>> Handle(GetProductWhereRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetWhereAsync(p => p.ProductName.Contains(request.Name));
            return  _mapper.Map<List<GetProductWhereResponse>>(product);
        }
    }
}
