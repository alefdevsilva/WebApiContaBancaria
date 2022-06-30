using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Interfaces
{
    public interface IContaCorrente
    {
        public bool Sacar(double valorDoSaque);
        public bool Depositar(double valorDposito);
        public double consultaSaldo();
    }
}
