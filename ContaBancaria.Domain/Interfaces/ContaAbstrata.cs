using ContaBancaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Interfaces
{
    public abstract class ContaAbstrata
    {
        public Cliente Titular { get; set; }
        public int NumeroDaconta { get; set; }
        public double Saldo { get; set; }

        public ContaAbstrata(Cliente Titular, int numeroDaconta, double saldo)
        {
            this.Titular = Titular;
            this.NumeroDaconta = numeroDaconta;
            this.Saldo = saldo;
        }
    }
}
