using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public Endereco Endereco { get; set; }

        public Cliente(string nome, string rg, string cpf, Endereco enredero)
        {
            Endereco = enredero;
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
        }
    }
}
