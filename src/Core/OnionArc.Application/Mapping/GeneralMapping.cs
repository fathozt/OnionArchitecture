using AutoMapper;
using OnionArc.Application.Features.Commands.CreateProduct;
using OnionArc.Application.Features.Queries.Category.GetAllCategories;
using OnionArc.Application.Features.Queries.GetAllProducts;
using OnionArc.Application.Features.Queries.GetProductById;
using OnionArc.Application.Features.Queries.GetProductWhere;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetAllProductQueryResponse>()
                 .ReverseMap();
            CreateMap<Product, GetProductByIdResponse>()
                .ReverseMap();
            CreateMap<Product, CreateProductCommandRequest>()
                .ReverseMap();
            CreateMap<Product, CreateProductCommandResponse>()
                .ReverseMap();
            CreateMap<Product, GetProductWhereResponse>()
                .ReverseMap();
            CreateMap<Category, GetAllCategoryQueryResponse>()
                .ReverseMap();

        }
    }
}
