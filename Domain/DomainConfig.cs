using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class DomainConfig
    {
        public static IServiceCollection AddDomain(this IServiceCollection services, string sqlConnStr)
        {
            services.AddDbContext<TelePhoneContext>(options =>
                options.UseSqlServer(sqlConnStr));
            return services;
        }
    }
}
