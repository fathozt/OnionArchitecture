using Microsoft.EntityFrameworkCore;
using OnionArc.Application.Interfaces.Repositories.Abstracts;
using OnionArc.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnionArc.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly OnionArcDbContext _onionArcDbContext;

        public Repository(OnionArcDbContext onionArcDbContext)
        {
            _onionArcDbContext = onionArcDbContext;
        }

        private DbSet<T> Table { get => _onionArcDbContext.Set<T>(); }

        public async Task<T> AddAsync(T model)
        {
            await Table.AddAsync(model);
            _onionArcDbContext.SaveChanges();
            return model;
        }

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.Where(expression).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> RemoveAsync(T model)
        {
            Table.Remove(model);
            await _onionArcDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<T> SingleOrDefault(Expression<Func<T, bool>> expression)
        {
            return await Table.FirstOrDefaultAsync(expression);
        }

        public DbSet<T> GetTable()
        {
            return  _onionArcDbContext.Set<T>();
        }
    }
}
