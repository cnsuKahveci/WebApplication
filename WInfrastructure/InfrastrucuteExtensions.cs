using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WInfrastructure.Context;
using WDomain.Entities;
using Npgsql;


namespace WInfrastructure
{
    public static class InfrastrucuteExtensions
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<WDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgresConnection")));
            
            services.Configure<OrderDatabaseSettings>(configuration.GetSection(nameof(OrderDatabaseSettings)));
            services.AddSingleton<IOrderDatabaseSettings>(sp => 
                sp.GetRequiredService<IOptions<OrderDatabaseSettings>>().Value);
            
            services.AddScoped<IDbConnection>(db=>new NpgsqlConnection(configuration.GetConnectionString("PostgresConnection")));
           
            
            return services;

        }
    }
    
}