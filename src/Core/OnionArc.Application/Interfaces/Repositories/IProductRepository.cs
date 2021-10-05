using OnionArc.Application.Features.Commands.CreateProduct;
using OnionArc.Application.Interfaces.Repositories.Abstracts;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<bool> AddProduct(CreateProductCommandRequest request);
    }
}
