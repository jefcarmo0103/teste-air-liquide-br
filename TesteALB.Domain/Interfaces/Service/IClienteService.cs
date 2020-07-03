using System;
using System.Collections.Generic;
using System.Text;
using TesteALB.Domain.Entities;

namespace TesteALB.Domain.Interfaces.Service
{
    public interface IClienteService : IDisposable
    {
        void Add(Cliente cliente);
        void Update(int id, Cliente cliente);
        IEnumerable<Cliente> GetAll();
        void Delete(int id);

    }
}
