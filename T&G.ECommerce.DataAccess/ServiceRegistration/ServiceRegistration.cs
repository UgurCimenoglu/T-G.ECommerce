using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using T_G.ECommerce.DataAccess.Abstract;
using T_G.ECommerce.DataAccess.Concrete;
using T_G.ECommerce.DataAccess.Context;

namespace T_G.ECommerce.DataAccess.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceDbContext>();

            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<ICategoryDal, CategoryDal>();
        }
    }
}
