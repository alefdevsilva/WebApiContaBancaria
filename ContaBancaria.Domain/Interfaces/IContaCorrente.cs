using ContaBancaria.Domain.Models;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Interfaces
{
    public interface IContaCorrente : IBaseRepositorio<ContaCorrente>
    {
        public bool Sacar(double valorDoSaque);
        public bool Depositar(double valorDposito);
        public double consultaSaldo();
        public IEnumerable<ContaCorrente> BuscarContaCorrenteCliente();
    }
}
