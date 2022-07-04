using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using ContaBancaria.Infra.Contexto;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Infra.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ContaBancariaContexto contaBancariaContexto) : base(contaBancariaContexto)
        {
        }
    }
}
