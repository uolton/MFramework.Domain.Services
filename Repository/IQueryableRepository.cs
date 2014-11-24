using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFramework.Common.Specifications;

namespace MFramework.Domain.Services.Repository
{
    public interface IQueryableRepository<TEntity>: IQueryable<TEntity>
     where TEntity :Entity<TEntity>
    {
        IQueryable<TEntity> For<TService>();
        IEnumerable<TEntity> Query(ISpecification<TEntity> specification);
    }
}
