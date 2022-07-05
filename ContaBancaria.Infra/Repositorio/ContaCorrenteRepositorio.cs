using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using ContaBancaria.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Repositorio.Repositorios;

namespace ContaBancaria.Infra.Repositorio
{
    public class ContaCorrenteRepositorio : BaseRepositorio<ContaCorrente>, IContaCorrente
    {
        public ContaCorrenteRepositorio(ContaBancariaContexto contaBancariaContexto) : base(contaBancariaContexto)
        {
        }

        public IEnumerable<ContaCorrente> BuscarContaCorrenteCliente()
        {
            var Correntes = ContaBancariaContexto.Set<ContaCorrente>().Include(cli => cli.Cliente).ToList();
            return Correntes;
        }

        public double consultaSaldo()
        {
            throw new NotImplementedException();
        }

        public bool Depositar(double valorDposito)
        {
            throw new NotImplementedException();
        }

        public bool Sacar(double valorDoSaque)
        {
            throw new NotImplementedException();
        }

        
    }
}
