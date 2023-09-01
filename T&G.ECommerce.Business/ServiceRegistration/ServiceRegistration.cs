using Microsoft.Extensions.DependencyInjection;
using T_G.ECommerce.Business.Abstract;
using T_G.ECommerce.Business.Concrete;
using T_G.ECommerce.DataAccess.Context;

namespace T_G.ECommerce.Business.ServiceRegistration
{
    // Layer based IoC service implementation
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
