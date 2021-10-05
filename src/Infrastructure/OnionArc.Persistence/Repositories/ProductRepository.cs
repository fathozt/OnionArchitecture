using AutoMapper;
using OnionArc.Application.Features.Commands.CreateProduct;
using OnionArc.Application.Interfaces.Repositories;
using OnionArc.Persistence.Context;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IImageRepository _imageRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductRepository(
            OnionArcDbContext onionArcDbContext,
            IImageRepository imageRepository,
            IProductRepository roductRepository,
            IMapper mapper) : base(onionArcDbContext)
        {
            _imageRepository = imageRepository;
            _productRepository = roductRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddProduct(CreateProductCommandRequest request)
        {
            var product = _mapper.Map<Product>(request);
            if (product != null)
            {
                return false;
            }

            var p = await _productRepository.AddAsync(product);

            await _imageRepository.AddProductImagesToFileSystem(request.Files, product.ProductName, p.Id);
            return true;

        }
    }
}
