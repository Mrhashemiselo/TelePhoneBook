using Microsoft.Extensions.DependencyInjection;

namespace Security
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSecurity(this IServiceCollection services)
        {
            return services;
        }
    }
}
