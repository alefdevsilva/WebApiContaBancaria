namespace ContaBancaria.Web.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; } = string.Empty;
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Pessoa(int id, string nomeCompleto)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
        }

    }
}
