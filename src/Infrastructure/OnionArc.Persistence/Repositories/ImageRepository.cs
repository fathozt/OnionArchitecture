using Microsoft.AspNetCore.Http;
using OnionArc.Application.Interfaces.Repositories;
using OnionArc.Persistence.Context;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Persistence.Repositories
{
    public class ImageRepository : Repository<ProductImage>, IImageRepository
    {
        ImageRepository _ImageRepository;
        public ImageRepository(
            OnionArcDbContext onionArcDbContext,
            ImageRepository imageRepository) : base(onionArcDbContext)
        {
            _ImageRepository = imageRepository;
        }
        public async Task AddProductImagesToFileSystem(List<IFormFile> files, string productName, int productId)
        {
            string wwwrootPath = Path.GetFullPath("Images");
            List<string> productImages = new();
            int i = 0;
            foreach (IFormFile image in files)
            {
                productImages.Add(productName + "-" + i + Path.GetExtension(image.FileName));
                FileStream fileStream = new(wwwrootPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
                fileStream.Close();
                fileStream.Dispose();
                i++;
            }
        }
    }
}
