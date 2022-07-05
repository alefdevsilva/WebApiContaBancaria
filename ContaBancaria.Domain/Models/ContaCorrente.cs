using ContaBancaria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class ContaCorrente : ContaAbstrata
    {
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public ContaCorrente(int id, int ClienteId, int numeroDaconta, double saldo) : base(id, numeroDaconta, saldo)
        {
            this.ClienteId = ClienteId;
        }
        public ContaCorrente()
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
