using ContaBancaria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class ContaPoupanca : ContaAbstrata, IContaPoupanca
    {
        public ContaPoupanca(Cliente Titular, int numeroDaconta, double saldo) : base(Titular, numeroDaconta, saldo)
        {
        }

        public double consultaSaldo()
        {
            return this.Saldo;
        }

        public bool Investimento()
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido + 1; //* 1.01;
            }
            return true;
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
