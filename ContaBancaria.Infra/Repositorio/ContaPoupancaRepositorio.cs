using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using ContaBancaria.Infra.Contexto;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Infra.Repositorio
{
    public class ContaPoupancaRepositorio : BaseRepositorio<ContaPoupanca>, IContaPoupancaRepositorio
    {
        public ContaPoupancaRepositorio(ContaBancariaContexto contaBancariaContexto) : base(contaBancariaContexto)
        {
        }
    }
}
