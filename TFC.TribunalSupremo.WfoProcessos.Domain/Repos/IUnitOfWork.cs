using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Repos
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
