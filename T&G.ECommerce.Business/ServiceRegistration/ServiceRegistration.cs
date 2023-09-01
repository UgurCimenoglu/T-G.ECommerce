using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using T_G.ECommerce.Business.Abstract;
using T_G.ECommerce.Business.Concrete;
using T_G.ECommerce.DataAccess.Context;

namespace T_G.ECommerce.Business.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceDbContext>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(typeof(ProductService));
        }
    }
}
