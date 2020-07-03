using System;
using System.Collections.Generic;
using System.Text;
using TesteALP.Application.Request;
using TesteALP.Application.Response;

namespace TesteALP.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        void Add(ClienteRequest request);
        void Update(int id, ClienteRequest request);
        void Delete(int id);
        IEnumerable<ClienteResponse> GetAll();

    }
}
