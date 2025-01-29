using AccountingService.Service.Impl;
using AccountingService.Service;
using Repository;
//using System.Text;
//using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DIConfig
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddUserRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository, RepositoryImpl>();
            return services;
        }
    }
}
