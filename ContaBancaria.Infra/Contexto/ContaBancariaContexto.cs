using System;
using System.Collections.Generic;
using System.Text;
using ContaBancaria.Domain.Models;
using ContaBancaria.Infra.Config;
using Microsoft.EntityFrameworkCore;

namespace ContaBancaria.Infra.Contexto
{
    public class ContaBancariaContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ContaCorrente> ContasCorrente { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ContaPoupanca> ConstasPoupanca { get; set; }
        public ContaBancariaContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ContaCorrenteConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new ContaPoupancaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
