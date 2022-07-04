using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContaBancaria.Web.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio usuarioRepositorio)
        {
            _clienteRepositorio = usuarioRepositorio;
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_clienteRepositorio.ObterPorId(id));
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
                return Ok(_clienteRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddAll([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Adicionar(cliente);
                return Created("api/product", cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Atualizar(cliente);
                return Ok(cliente);
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
                var cliente = _clienteRepositorio.ObterPorId(id);
                if(cliente.Id == null)
                {
                    return BadRequest("O Id não existe");
                }
                _clienteRepositorio.Remover(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
