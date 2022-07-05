using System;
using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContaBancaria.Web.Controllers
{
    [Route("api/[controller]")]
    public class ContaCorrenteController : Controller
    {
        private readonly IContaCorrente _correnteRepositorio;
        public ContaCorrenteController(IContaCorrente correnteRepositorio)
        {
            _correnteRepositorio = correnteRepositorio;
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_correnteRepositorio.ObterPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_correnteRepositorio.BuscarContaCorrenteCliente());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddAll([FromBody] ContaCorrente contaCorrente)
        {
            try
            {
                _correnteRepositorio.Adicionar(contaCorrente);
                return Created("api/product", contaCorrente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] ContaCorrente contaCorrente)
        {
            try
            {
                _correnteRepositorio.Atualizar(contaCorrente);
                return Ok(contaCorrente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("remove/{Id}")]
        public IActionResult RemoveById(int id)
        {
            try
            {
                var corrente = _correnteRepositorio.ObterPorId(id);
                if (corrente.Id == 0)
                {
                    return BadRequest("O Id não existe");
                }
                _correnteRepositorio.Remover(corrente);
                return Ok(corrente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
