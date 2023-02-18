using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Repository.Interface;
using RestaurantAPI.Repository.Service;

namespace RestaurantAPI.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", buillder => buillder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });

        public static void ConfigureIISintegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => { });
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<Contexts>(opts => opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
