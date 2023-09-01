using Microsoft.Extensions.DependencyInjection;
using T_G.ECommerce.DataAccess.Abstract;
using T_G.ECommerce.DataAccess.Concrete;

namespace T_G.ECommerce.DataAccess.ServiceRegistration
{

    // Layer based IoC service implementation
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<ICategoryDal, CategoryDal>();
        }
    }
}
