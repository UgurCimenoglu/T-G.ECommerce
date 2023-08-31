using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.DataAccess.Abstract;
using T_G.ECommerce.DataAccess.Context;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.DataAccess.Concrete
{
    public class ProductDal : EfRepositoryBase<Product, ECommerceDbContext>, IProductDal
    {
        public ProductDal(ECommerceDbContext context) : base(context)
        {
        }

    }
}
