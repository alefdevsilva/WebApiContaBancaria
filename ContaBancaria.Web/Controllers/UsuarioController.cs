using System;
using ContaBancaria.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;

namespace ContaBancaria.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Adicionar(usuario);
                return Created("api/produto", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
