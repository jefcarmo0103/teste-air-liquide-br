using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TesteALB.Domain.Entities;

namespace TesteALB.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IDisposable
    {
        void Add(Cliente obj);
        Cliente GetById(int id);
        ICollection<Cliente> GetAll();
        void Update(Cliente obj);
        void Remove(Cliente obj);
    }
}
