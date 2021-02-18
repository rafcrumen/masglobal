using Microsoft.Extensions.DependencyInjection;

namespace dal
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDalLibrary(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
