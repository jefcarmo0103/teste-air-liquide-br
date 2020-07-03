using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteALP.Infra.Context;
using Microsoft.Extensions.Configuration;

namespace TesteALB.Api.Configuration
{
    public static class ServiceDatabaseConfigExtension
    {
        public static void RegisterDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TesteALPDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
