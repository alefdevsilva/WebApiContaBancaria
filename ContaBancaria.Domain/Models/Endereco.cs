using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria.Domain.Models
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string pais)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Cep = cep;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Pais = pais;
        }
    }
}
