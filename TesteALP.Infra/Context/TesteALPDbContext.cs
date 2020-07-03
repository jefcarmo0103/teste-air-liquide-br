using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TesteALB.Domain.Entities;

namespace TesteALP.Infra.Context
{
    public class TesteALPDbContext : DbContext
    {
		public TesteALPDbContext(DbContextOptions<TesteALPDbContext> options)
			: base(options)
		{
		}

        public virtual DbSet<Cliente> Cliente { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>(entity =>
			{
				entity.Property(x => x.Id);

				entity.Property(x => x.Nome)
					.HasMaxLength(255);

				entity.Property(x => x.Idade);
			});
		}
    }
}
