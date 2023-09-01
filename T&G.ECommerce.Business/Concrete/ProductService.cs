using Microsoft.EntityFrameworkCore;
using T_G.ECommerce.Business.Abstract;
using T_G.ECommerce.Core.DataAccess.Paging;
using T_G.ECommerce.Core.Request;
using T_G.ECommerce.DataAccess.Abstract;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.Business.Concrete
{
    public class ProductService : IProductService
    {
        //I called productDal instance from IoC with constructor injection 
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //Products listed with pagination and filter criterias
        public IPaginate<Product> GetList(PageRequest pageRequest, Filter filter)
        {
            var res = _productDal.GetList(
                predicate: q =>
                    (filter.CategoryId == null || q.CategoryId == filter.CategoryId) &&
                    (filter.MinPrice == null || q.Price >= filter.MinPrice) &&
                    (filter.Rating == null || q.Rating >= filter.Rating && q.Rating < filter.Rating + 1) &&
                    (filter.MaxPrice == null || q.Price <= filter.MaxPrice),
                orderBy: filter.OrderBy == "asc" ? q => q.OrderBy(p => p.Price) :
                filter.OrderBy == "desc" ? q => q.OrderByDescending(p => p.Price) : null,
                index: pageRequest.Page,
                size: pageRequest.PageSize,
                enableTracking: false);
            return res;
        }
    }
}
