using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContaBancaria.Web.Controllers
{
    [Route("api/[controller]")]
    public class ContaPoupancaController : Controller
    {
        private readonly IContaPoupancaRepositorio _contaPoupancaRepositorio;

        public ContaPoupancaController(IContaPoupancaRepositorio contaPoupancaRepositorio)
        {
            _contaPoupancaRepositorio = contaPoupancaRepositorio;
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_contaPoupancaRepositorio.ObterPorId(id));
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
                return Ok(_contaPoupancaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Sacar")]
        public IActionResult Sacar([FromBody] ContaPoupanca contaPoupanca)
        {
            try
            {
                var poupanca = _contaPoupancaRepositorio.ObterPorId(contaPoupanca.Id);

                poupanca.Sacar(contaPoupanca.Saldo);
                _contaPoupancaRepositorio.Atualizar(poupanca);
                return Ok(poupanca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Depositar")]
        public IActionResult Depositar([FromBody] ContaPoupanca contaPoupanca)
        {
            try
            {
                var poupanca = _contaPoupancaRepositorio.ObterPorId(contaPoupanca.Id);
                poupanca.Depositar(contaPoupanca.Saldo);
                _contaPoupancaRepositorio.Atualizar(poupanca);
                return Ok(poupanca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddAll([FromBody] ContaPoupanca poupanca)
        {
            try
            {
                _contaPoupancaRepositorio.Adicionar(poupanca);
                return Created("api/product", poupanca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] ContaPoupanca poupanca)
        {
            try
            {
                _contaPoupancaRepositorio.Atualizar(poupanca);
                return Ok(poupanca);
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
                var poupanca = _contaPoupancaRepositorio.ObterPorId(id);
                if (poupanca.Id == null)
                {
                    return BadRequest("O Id não existe");
                }
                _contaPoupancaRepositorio.Remover(poupanca);
                return Ok(poupanca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
