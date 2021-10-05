using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionArc.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArc.Application.Features.Queries.Category.GetAllCategories
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, List<GetAllCategoryQueryResponse>>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            //var categories = await _categoryRepository.GetTable().Include(x => x.Categories).ThenInclude(x => x.Categories).Where(x => x.ParentId == null).ToListAsync();

            var categories = await _categoryRepository.GetTable().Include(c => c.Categories).ToListAsync();

            return _mapper.Map<List<GetAllCategoryQueryResponse>>(categories);
        }
    }
}
