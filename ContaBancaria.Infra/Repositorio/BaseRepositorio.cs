using System.Collections.Generic;
using System.Linq;
using ContaBancaria.Infra.Contexto;
using QuickBuy.Dominio.Contratos;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ContaBancariaContexto ContaBancariaContexto;
        public BaseRepositorio(ContaBancariaContexto contaBancariaContexto)
        {
            ContaBancariaContexto = contaBancariaContexto;
        }
        public void Adicionar(TEntity entity)
        {
            ContaBancariaContexto.Set<TEntity>().Add(entity);
            ContaBancariaContexto.SaveChanges();
        }
        
        public void Atualizar(TEntity entity)
        {
            ContaBancariaContexto.Set<TEntity>().Update(entity);
            ContaBancariaContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return ContaBancariaContexto.Set<TEntity>().Find(id);
       
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ContaBancariaContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ContaBancariaContexto.Remove(entity);
            ContaBancariaContexto.SaveChanges();
        }

        public void Dispose()
        {
            //Descartar o objeto de contexto da memória
            ContaBancariaContexto.Dispose();
        }
    }
}