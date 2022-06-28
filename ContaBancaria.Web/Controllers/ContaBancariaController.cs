using System.Collections.Generic;
using ContaBancaria.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaBancaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaBancariaController
    {
        string nome = "Alef";
        List<Pessoa> pessoas = new List<Pessoa>();

        [HttpGet("api/pessoas")]
        public IEnumerable<Pessoa> RetornaNomes()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.NomeCompleto = "Alef Silva";
            Pessoa pessoa2 = new Pessoa();
            pessoa2.NomeCompleto = "Will";
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
          

            return pessoas;
        }

        [HttpPost("api/AdicionarPessoas")]
        public List<Pessoa> AdicionarPessoas(List<Pessoa> pessoas)
        {
            return pessoas;
        }

        [HttpPost("api/AdicionarPessoa")]
        public Pessoa AdicionarPessoas(Pessoa pessoa)
        {
            return pessoa;
        }
    }
}
