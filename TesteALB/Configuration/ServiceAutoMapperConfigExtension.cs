using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteALP.Application.AutoMapper;

namespace TesteALB.Api.Configuration
{
    public static class ServiceAutoMapperConfigExtension
    {
        public static void RegisterAutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToResponseMappingProfile), typeof(RequestToDomainMappingProfile));
        }
    }
}
