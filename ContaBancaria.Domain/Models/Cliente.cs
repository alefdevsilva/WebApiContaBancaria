using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; } 
       
        public Cliente(string nome, string rg, string cpf)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
        }
        public Cliente()
        { 
        }
    }
}
