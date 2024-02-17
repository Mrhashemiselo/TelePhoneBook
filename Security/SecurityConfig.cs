using Microsoft.Extensions.DependencyInjection;

namespace Security
{
    public static class SecurityConfig
    {
        public static IServiceCollection AddSecurity(this IServiceCollection services)
        {
            return services;
        }
    }
}
