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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnionArcDbContext onionArcDbContext) : base(onionArcDbContext) { }
    }
}
