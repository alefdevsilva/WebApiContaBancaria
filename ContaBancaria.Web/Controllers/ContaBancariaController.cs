using System.Collections.Generic;
using System.Linq;
using ContaBancaria.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaBancaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaBancariaController : Controller
    {
        List<Pessoa> pessoas = new List<Pessoa>();
 
        //Buscar Todos
        [HttpGet("api/pessoas")]
        public IEnumerable<Pessoa> GetAll()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.NomeCompleto = "Alef Silva";
            Pessoa pessoa2 = new Pessoa();
            pessoa2.Id = 2;
            pessoa2.NomeCompleto = "Will";
            pessoa2.Idade = 22;
            pessoa2.Endereco = "Sao Paulo";
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(new Pessoa() {Id = 4, NomeCompleto = "Maria Santos", Idade = 20, Endereco = "Rua das Garças"});
            pessoas.Add(new Pessoa { Id = 5, NomeCompleto = "Madalena", Idade = 25, Endereco = "Rua tres" });
            //pessoas.Remove(pessoa1);
            //pessoas.RemoveAt(0);

            List<string> listaString = new List<string>(); 
            listaString.Add("Alef");
            listaString.Add("Will");
            string Alef = "Alef";
            bool EhAlef = listaString.Contains(Alef);

            /*
            foreach(var obj in pessoas)
            {
                if(obj.Idade == 0)
                {
                    obj.Idade += 1;
                }
            }
            */
            
            var pessoasMais20Anos = pessoas.Where(i => i.Idade > 20);
            var pessoasCom20Anos = pessoas.Where(i => i.Idade == 20);
            var pessoasMenor20Anos = pessoas.Where(i => i.Idade < 20);
            var pesssoasComIdadeIgualZero = pessoas.Where(i => i.Idade == 0);
            
            int SomaTotalIdade = pessoas.Sum(i => i.Idade);
            double MediaIdade = pessoas.Average(i => i.Idade);

            return pessoas;
        }

        //Buscar por Id
        [HttpGet("api/pessoa/{id}")]
        public Pessoa GetById(int id)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = id;
            return pessoa;
        }

        //Adicionar vários registros
        [HttpPost("api/AdicionarPessoas")]
        public List<Pessoa> Post([FromBody]List<Pessoa> pessoas)
        {
            return pessoas;
        }

        //Adicionar um registro
        [HttpPost("api/AdicionarPessoa")]
        public ActionResult<Pessoa> Post([FromBody]Pessoa pessoa)
        {
            pessoa.NomeCompleto += " Atualizado";
            return (pessoa);
        }

        //Alterar um registro
        [HttpPut("api/AlterarPessoa/{id}")]
        public ActionResult<Pessoa> Put([FromBody]Pessoa pessoa, int id)
        {
            if(id == pessoa.Id)
            {
                pessoa.NomeCompleto = "Nome Atualizado!";
            }
            return BadRequest();
        }

        //Deletar um registro
        [HttpDelete("api/DeletarPessoa/{id}")]
        public ActionResult<Pessoa> Delete(int id)
        {
            return new Pessoa();
        }
    }
}
