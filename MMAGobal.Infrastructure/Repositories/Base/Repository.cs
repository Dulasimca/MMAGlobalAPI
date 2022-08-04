using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMAGlobal.Core.Repositories.Base;
using MMAGlobal.Infrastructure.Data;

namespace MMAGlobal.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MMAGlobalTestContext _MMAGlobalTestContext;

        public Repository(MMAGlobalTestContext globalTestContext)
        {
            _MMAGlobalTestContext = globalTestContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _MMAGlobalTestContext.Set<T>().AddAsync(entity);
            await _MMAGlobalTestContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _MMAGlobalTestContext.Set<T>().Remove(entity);
            await _MMAGlobalTestContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _MMAGlobalTestContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _MMAGlobalTestContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await  _MMAGlobalTestContext.Set<T>().AddAsync(entity);
            _MMAGlobalTestContext.Entry(entity).State = EntityState.Modified;
            await _MMAGlobalTestContext.SaveChangesAsync();
        }
    }
}
