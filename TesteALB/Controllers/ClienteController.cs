using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteALP.Application.Interfaces;
using TesteALP.Application.Request;
using TesteALP.Application.Response;

namespace TesteALB.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        public IEnumerable<ClienteResponse> GetAll()
        {
            return _clienteAppService.GetAll();
        }

        [HttpPost]
        public void Add(ClienteRequest request)
        {
            _clienteAppService.Add(request);
        }

        [HttpPut]
        public void Update([FromQuery] int id, [FromBody]ClienteRequest request)
        {
            _clienteAppService.Update(id, request);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _clienteAppService.Delete(id);
        }
    }
}
