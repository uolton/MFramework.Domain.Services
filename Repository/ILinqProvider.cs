using System.Linq;

namespace MFramework.Domain.Services.Repository
{
    /// <summary>
    /// </summary>
    public interface ILinqProvider
    {
        /// <summary>
        ///     Query object for concrete <see cref="Entity" />
        /// </summary>
        /// <typeparam name="TEntity">
        ///     <see cref="Entity" />
        /// </typeparam>
        /// <returns>
        ///     <see cref="IQueryable{TEntity}" /> object for type of TEntity
        /// </returns>
        IQueryable<TEntity> Query<TEntity>()
            where TEntity : Entity<TEntity>, new();
    }
}