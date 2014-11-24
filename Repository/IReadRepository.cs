using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFramework.Domain.Services.Repository
{
    public interface IReadRepository<TEntity> : IQueryableRepository<TEntity>, ISelectableRepository<TEntity>, IReadRepositoryWithTypedId<TEntity,int>
     where TEntity : Entity<TEntity>,new()
    {
    }
}
