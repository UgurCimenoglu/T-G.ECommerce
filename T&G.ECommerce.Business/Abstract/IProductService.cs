using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Core.DataAccess.Paging;
using T_G.ECommerce.Core.Request;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.Business.Abstract
{
    public interface IProductService
    {
        IPaginate<Product> GetList(PageRequest pageRequest, Filter filter);
    }
}
