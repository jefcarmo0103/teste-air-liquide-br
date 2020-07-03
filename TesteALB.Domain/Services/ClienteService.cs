using System;
using System.Collections.Generic;
using System.Text;
using TesteALB.Domain.Entities;
using TesteALB.Domain.Interfaces.Repository;
using TesteALB.Domain.Interfaces.Service;

namespace TesteALB.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Add(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public void Delete(int id)
        {
            var clienteDb = _clienteRepository.GetById(id);
            if (clienteDb != null)
                throw new Exception("Usuário não encontrado");

            _clienteRepository.Remove(clienteDb);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public void Update(int id, Cliente cliente)
        {
            var clienteDb = _clienteRepository.GetById(id);
            if (clienteDb != null)
                throw new Exception("Usuário não encontrado");

            clienteDb.Nome = cliente.Nome;
            clienteDb.Idade = cliente.Idade;

            _clienteRepository.Update(clienteDb);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
