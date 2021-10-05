using AutoMapper;
using MediatR;
using OnionArc.Application.Interfaces.Repositories;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            //var product = _mapper.Map<Product>(request);
            //Product p = await _productRepository.AddAsync(product);
            return new CreateProductCommandResponse()
            {
                Message = (await _productRepository.AddProduct(request)).ToString()
            };
        }
    }
}
