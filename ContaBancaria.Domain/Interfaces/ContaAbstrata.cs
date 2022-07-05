using ContaBancaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Interfaces
{
    public abstract class ContaAbstrata
    {
        public int Id { get; set; }
        public int NumeroDaconta { get; set; }
        public double Saldo { get; set; }

        public ContaAbstrata(int id, int numeroDaconta, double saldo)
        {
            this.Id = id;
            this.NumeroDaconta = numeroDaconta;
            this.Saldo = saldo;
        }
        public ContaAbstrata()
        {

        }
    }
}
