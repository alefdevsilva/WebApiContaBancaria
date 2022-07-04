using ContaBancaria.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Infra.Config
{
    public class ContaPoupancaConfiguration : IEntityTypeConfiguration<ContaPoupanca>
    {
        public void Configure(EntityTypeBuilder<ContaPoupanca> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NumeroDaconta)
                .IsRequired();

            builder.Property(x => x.Saldo)
                .IsRequired();
        }
    }
}
