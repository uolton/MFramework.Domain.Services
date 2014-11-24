using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MFramework.Common.Specifications;
using MFramework.Domain;


namespace MFramework.Domain.Services.Repository
{
    public interface IReadRepositoryWithTypedId<TEntity, TId> 
     where TEntity :Entity<TEntity>
    {
        TEntity Get(TId id);
        IList<TEntity> GetAll();
        
    }
}
