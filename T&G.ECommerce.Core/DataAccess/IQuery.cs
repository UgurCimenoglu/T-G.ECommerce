using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_G.ECommerce.Core.DataAccess
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}
