﻿using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using T_G.ECommerce.Core.DataAccess.Paging;
using T_G.ECommerce.Core.Entities;

namespace T_G.ECommerce.Core.DataAccess
{
    //Generic async repository pattern interface 
    public interface IAsyncRepository<T> : IQuery<T> where T : Entity
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IPaginate<T>> GetListAsync(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            int index = 0, int size = 9, bool enableTracking = true,
            CancellationToken cancellationToken = default);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
