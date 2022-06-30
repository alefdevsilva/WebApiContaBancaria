using ContaBancaria.Domain.Models;
using ContaBancaria.Infra.Contexto;
using QuickBuy.Dominio.Contratos;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ContaBancariaContexto contaBancariaContexto) : base(contaBancariaContexto)
        {
        }
    }
}
