using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteALB.Domain.Entities;
using TesteALP.Application.Response;

namespace TesteALP.Application.AutoMapper
{
    public class DomainToResponseMappingProfile : Profile
    {
        public DomainToResponseMappingProfile()
        {
            CreateMap<Cliente, ClienteResponse>();
        }
        
    }
}
