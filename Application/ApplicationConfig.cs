using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationConfig
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
