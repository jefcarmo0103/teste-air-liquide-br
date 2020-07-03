using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteALB.Domain.Entities;
using TesteALB.Domain.Interfaces.Repository;
using TesteALP.Infra.Context;

namespace TesteALP.Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        protected readonly TesteALPDbContext Db;
        protected readonly DbSet<Cliente> DbSet;
        public ClienteRepository(TesteALPDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Cliente>();
        }
        public void Add(Cliente obj)
        {
            Db.Add(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public ICollection<Cliente> GetAll()
        {
            return DbSet.ToList();
        }

        public Cliente GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Cliente obj)
        {
            DbSet.Remove(obj);
        }

        public void Update(Cliente obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
        }
    }
}
