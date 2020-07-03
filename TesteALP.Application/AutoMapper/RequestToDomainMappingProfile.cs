using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteALB.Domain.Entities;
using TesteALP.Application.Request;

namespace TesteALP.Application.AutoMapper
{
    public class RequestToDomainMappingProfile : Profile
    {
        public RequestToDomainMappingProfile()
        {
            CreateMap<ClienteRequest, Cliente>();
        }
    }
}
