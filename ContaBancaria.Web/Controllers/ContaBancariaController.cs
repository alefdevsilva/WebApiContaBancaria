using ContaBancaria.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaBancaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaBancariaController
    {
        
        Pessoa pessoa = new Pessoa(1, "Alef Silva");
        [HttpGet("{pessoas}")]
        public Pessoa RetornaNome()
        {
            return pessoa;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
    }
}
