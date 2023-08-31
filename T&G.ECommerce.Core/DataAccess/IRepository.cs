using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using T_G.ECommerce.Core.DataAccess.Paging;
using T_G.ECommerce.Core.Entities;

namespace T_G.ECommerce.Core.DataAccess
{
    public interface IRepository<T> : IQuery<T> where T : Entity
    {
        T Get(Expression<Func<T, bool>> predicate);

        IPaginate<T> GetList(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            int index = 0, int size = 9,
            bool enableTracking = true);

        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
