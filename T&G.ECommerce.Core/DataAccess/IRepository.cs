using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using T_G.ECommerce.Core.DataAccess.Paging;
using T_G.ECommerce.Core.Entities;

namespace T_G.ECommerce.Core.DataAccess
{
    //Generic repository desing pattern  sync interface
    public interface IRepository<T> : IQuery<T> where T : Entity
    {
        IList<T> GetAll();
        T Get(Expression<Func<T, bool>> predicate);

        // I passed 5 parameters, first parameter provides linq expression, second parameter for query ordered, third parameter can get relational data
        //fourth parameter for pagination and last parameter data tracking, usually we don't use data tracking for queries 
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
