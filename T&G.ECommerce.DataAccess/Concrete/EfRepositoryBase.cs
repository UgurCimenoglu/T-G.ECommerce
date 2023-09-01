using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using T_G.ECommerce.Core.DataAccess;
using T_G.ECommerce.Core.Entities;
using T_G.ECommerce.Core.DataAccess.Paging;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace T_G.ECommerce.DataAccess.Concrete
{
    public class EfRepositoryBase<TEntity, TContext> : IAsyncRepository<TEntity>, IRepository<TEntity>
        where TEntity : Entity
    where TContext : DbContext
    {
        protected TContext Context { get; }

        //dbcontext constractor injection
        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        //create IQueryable TEntity instance
        public IQueryable<TEntity> Query()
        {
            return Context.Set<TEntity>();
        }

        // Get a data with linq query async
        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
        => await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        //Get data list with pagination async
        public async Task<IPaginate<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null,
                                                                                          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                                                          Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                                                                                          int index = 0,
                                                                                          int size = 9,
                                                                                          bool enableTracking = true,
                                                                                          CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query(); //We created IQueryable instance
            if (!enableTracking) queryable.AsNoTracking(); // set enable/disable tracking 
            if (include != null) include(queryable); // if there is include, set includable data
            if (predicate != null) queryable.Where(predicate); //if linq expression set
            if (orderBy != null)  // orderby setting
                return await orderBy(queryable).ToPaginateAsync(index, size, 0, cancellationToken);
            return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);

        }

        // Adding process async 
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return entity;
        }

        // Updating process async
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        // Deleting process async
        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entity;
        }

        //GetAll List of typeof T 
        public IList<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        // Get a data with linq query
        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
            => Context.Set<TEntity?>().FirstOrDefault(predicate);

        //Get data list with pagination
        public IPaginate<TEntity> GetList(Expression<Func<TEntity,
                                                             bool>>? predicate = null,
                                                             Func<IQueryable<TEntity>,
                                                             IOrderedQueryable<TEntity>>? orderBy = null,
                                                             Func<IQueryable<TEntity>,
                                                             IIncludableQueryable<TEntity, object>>? include = null,
                                                             int index = 0,
                                                             int size = 9,
                                                             bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();  //We created IQueryable instance
            if (!enableTracking) queryable = queryable.AsNoTracking(); // set tracking 
            if (include != null) queryable = include(queryable);  // if there is include, set includable data
            if (predicate != null) queryable = queryable.Where(predicate); //if linq expression set 
            if (orderBy != null)  // orderby setting
                return orderBy(queryable).ToPaginate(index, size);
            return queryable.ToPaginate(index, size);
        }

        //adding process
        public TEntity Add(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            Context.SaveChanges();
            return entity;
        }

        //updating process
        public TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }

        //deleting process
        public TEntity Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
            return entity;
        }

    }
}
