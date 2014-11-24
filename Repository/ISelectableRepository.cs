using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MFramework.Domain.Services.Repository.Select;

namespace MFramework.Domain.Services.Repository
{
    public interface ISelectableRepository<TEntity>
     where TEntity :Entity<TEntity>,new()

    {
        IEnumerable<TEntity> Select(
            Expression<Func<TEntity, bool>> whereClause = null,
            IOrderByClause<TEntity>[] orderBy = null,
            int skip = 0,
            int top = 0,
            string[] include = null);

    }
}
