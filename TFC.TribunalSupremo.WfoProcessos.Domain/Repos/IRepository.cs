using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Repos
{
    public interface IRepository<TEntity>
        where TEntity : IEntidade
    {
        void Add(TEntity entidade);

        void Update(TEntity entidade);

        void Delete(Guid id);

        TEntity GetById(Guid Id);

        IQueryable<TEntity> Query();

    }
}
