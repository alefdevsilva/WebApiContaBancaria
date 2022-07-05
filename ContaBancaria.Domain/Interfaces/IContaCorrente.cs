using ContaBancaria.Domain.Models;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Interfaces
{
    public interface IContaCorrente : IBaseRepositorio<ContaCorrente>
    {
        public bool Sacar(double valorDoSaque);//post
        public bool Depositar(double valorDposito);//post
        public double consultaSaldo();//get
        public IEnumerable<ContaCorrente> BuscarContaCorrenteCliente();
    }
}
