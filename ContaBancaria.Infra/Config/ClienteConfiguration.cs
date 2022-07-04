using ContaBancaria.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Infra.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.Rg)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
