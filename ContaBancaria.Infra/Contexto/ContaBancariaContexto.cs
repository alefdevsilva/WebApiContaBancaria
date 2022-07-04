using System;
using System.Collections.Generic;
using System.Linq;
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
            ForgottenPropertyMapping(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        private void ForgottenPropertyMapping(ModelBuilder modelBuilder)
        {
            foreach(var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(x => x.ClrType == typeof(string));
                foreach(var property in properties)
                {
                    if (String.IsNullOrEmpty(property.GetColumnType())
                        && !property.GetMaxLength().HasValue)
                    {
                        property.SetMaxLength(150);
                    }
                }
            }
        }
    }
}
