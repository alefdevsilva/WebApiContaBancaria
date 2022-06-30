using ContaBancaria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class ContaCorrente : ContaAbstrata, IContaCorrente
    {
        public ContaCorrente(Cliente Titular, int numeroDaconta, double saldo) : base(Titular, numeroDaconta, saldo)
        {
        }

        public double consultaSaldo()
        {
            return this.Saldo;
        }

        public bool Depositar(double valorDposito)
        {
            if (valorDposito > 0)
            {
                this.Saldo += valorDposito;
                return true;
            }
            return false;
        }

        public bool Sacar(double valorDeSaque)
        {
            this.Saldo -= 1;
            if (this.Saldo >= valorDeSaque)
            {
                this.Saldo -= valorDeSaque;
                return true;
            }
            return false;
        }
    }
}
