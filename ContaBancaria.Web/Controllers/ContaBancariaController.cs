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

        //Buscar Todos
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
        //Buscar por Id
        [HttpGet("api/pessoa/{id}")]
        public Pessoa RetornaNome(int id)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = id;
            
            return pessoa;
        }

        //Adicionar vários registros
        [HttpPost("api/AdicionarPessoas")]
        public List<Pessoa> AdicionarPessoas(List<Pessoa> pessoas)
        {
            return pessoas;
        }

        //Adicionar um registro
        [HttpPost("api/AdicionarPessoa")]
        public Pessoa AdicionarPessoas(Pessoa pessoa)
        {
            return pessoa;
        }

        //Alterar um registro
        [HttpPut("api/AlterarPessoa/{id}")]
        public Pessoa AlterarPessoa(Pessoa pessoa, int id)
        {
            pessoa = new Pessoa();
            pessoa.NomeCompleto = "Nome Atualizado!"; 
            return pessoa;
        }

        //Deletar um registro
        [HttpDelete("api/DeletarPessoa/{id}")]
        public ActionResult<Pessoa> DeletarPessoa(int id)
        {
            return new Pessoa();
        }
    }
}
