using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFC.TribunalSupremo.WfoProcessos.Domain.Repos;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Data.Repositorios
{
    public class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntidade
    {
        #region Propriedades
        
        #endregion

        public virtual void Add(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entidade)
        {
            throw new NotImplementedException();
        }
    }
}
