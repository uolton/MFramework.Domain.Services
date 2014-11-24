using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFramework.Domain.Services.Repository
{
    public interface IWriteRepository<TEntity>
        where TEntity : Entity<TEntity>
    {
        /// <summary>
        /// Adds a transient instance of <paramref name="entity"/> to be tracked
        /// and persisted by the repository.
        /// </summary>
        /// <param name="entity">An instance of <typeparamref name="TEntity"/> to be persisted.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Marks the changes of an existing entity to be saved to the store.
        /// </summary>
        /// <param name="entity">An instance of <typeparamref name="TEntity"/> that should be
        /// updated in the database.</param>
        /// <remarks>Implementors of this method must handle the Update scneario. </remarks>
        void Delete(TEntity entity);

        /// <summary>
        /// Detaches a instance from the repository.
        /// </summary>
        /// <param name="entity">The entity instance, currently being tracked via the repository, to detach.</param>
        /// <exception cref="NotSupportedException">Implentors should throw the NotImplementedException if Detaching
        /// entities is not supported.</exception>
        void Detach(TEntity entity);

        /// <summary>
        /// Attaches a detached entity, previously detached via the <see cref="Detach"/> method.
        /// </summary>
        /// <param name="entity">The entity instance to attach back to the repository.</param>
        /// <exception cref="NotSupportedException">Implentors should throw the NotImplementedException if Attaching
        /// entities is not supported.</exception>
        void Attach(TEntity entity);

        /// <summary>
        /// Refreshes a entity instance.
        /// </summary>
        /// <param name="entity">The entity to refresh.</param>
        /// <exception cref="NotSupportedException">Implementors should throw the NotImplementedException if Refreshing
        /// entities is not supported.</exception>
        void Refresh(TEntity entity);

    }
}
