using Microsoft.AspNetCore.Http;
using OnionArc.Application.Interfaces.Repositories.Abstracts;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Interfaces.Repositories
{
    public interface IImageRepository : IRepository<ProductImage>
    {
        Task AddProductImagesToFileSystem(List<IFormFile> files, string productName, int productId);
    }
}
