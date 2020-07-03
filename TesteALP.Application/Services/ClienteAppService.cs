using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteALB.Domain.Entities;
using TesteALB.Domain.Interfaces.Service;
using TesteALP.Application.Interfaces;
using TesteALP.Application.Request;
using TesteALP.Application.Response;

namespace TesteALP.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;
        public ClienteAppService(IClienteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public void Add(ClienteRequest request)
        {
            _service.Add(_mapper.Map<Cliente>(request));
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ClienteResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<ClienteResponse>>(_service.GetAll());
        }

        public void Update(int id, ClienteRequest request)
        {
            _service.Update(id, _mapper.Map<Cliente>(request));
        }
    }
}
