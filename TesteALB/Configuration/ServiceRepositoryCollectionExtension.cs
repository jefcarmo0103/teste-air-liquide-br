using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteALB.Domain.Interfaces.Repository;
using TesteALB.Domain.Interfaces.Service;
using TesteALB.Domain.Services;
using TesteALP.Application.Interfaces;
using TesteALP.Application.Services;
using TesteALP.Infra.Repository;

namespace TesteALB.Configuration
{
    public static class ServiceRepositoryCollectionExtension
    {
        public static IServiceCollection RegisterRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteAppService, ClienteAppService>();

            return services;
        }
    }
}
