using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArc.Application.Features.Commands.CreateProduct;
using OnionArc.Application.Features.Queries.GetAllProducts;
using OnionArc.Application.Features.Queries.GetProductById;
using OnionArc.Application.Features.Queries.GetProductWhere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await mediator.Send(new GetAllProductQueryRequest());
            return Ok(res);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetProductByIdRequest request)
        {
            var res = await mediator.Send(request);
            return Ok(res);
        }

        [HttpGet("search/{Name}")]
        public async Task<List<GetProductWhereResponse>> GetWhere([FromRoute] GetProductWhereRequest request)
        {
            return await mediator.Send(request);
        }
        
        [HttpPost]
        public async Task<CreateProductCommandResponse> Post([FromForm]
        CreateProductCommandRequest request)
        {
            return await mediator.Send(request);
        }
    }
}
