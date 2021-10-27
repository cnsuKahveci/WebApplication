using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WInfrastructure.Context;

namespace WInfrastructure
{
    public static class InfrastrucuteExtensions
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<WDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgresConnection")));

            return services;
        }
    }
    
}