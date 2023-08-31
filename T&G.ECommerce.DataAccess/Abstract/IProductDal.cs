using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Core.DataAccess;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.DataAccess.Abstract
{
    public interface IProductDal : IAsyncRepository<Product>, IRepository<Product>
    {
    }
}
