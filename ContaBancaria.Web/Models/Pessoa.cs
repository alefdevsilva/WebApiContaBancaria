using System.ComponentModel.DataAnnotations;

namespace ContaBancaria.Web.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; } 
        public string Endereco { get; set; }
        public int Idade { get; set; }
    }
}
