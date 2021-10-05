using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnionArc.Application.Interfaces.Repositories.Abstracts
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T model);
        Task<T> RemoveAsync(T model);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<T> SingleOrDefault(Expression<Func<T, bool>> expression);
        DbSet<T> GetTable();
    }
}
