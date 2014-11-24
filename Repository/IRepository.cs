#region license
//Copyright 2010 Ritesh Rao 

//Licensed under the Apache License, Version 2.0 (the "License"); 
//you may not use this file except in compliance with the License. 
//You may obtain a copy of the License at 

//http://www.apache.org/licenses/LICENSE-2.0 

//Unless required by applicable law or agreed to in writing, software 
//distributed under the License is distributed on an "AS IS" BASIS, 
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
//See the License for the specific language governing permissions and 
//limitations under the License. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using MFramework.Common.Specifications;
using MFramework.Domain.Services.Transactions;

namespace MFramework.Domain.Services.Repository
{
    /// <summary>
    /// The <see cref="IRepository{TEntity}"/> interface defines a standard contract that repository
    /// components should implement.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity that the repository encapsulates.</typeparam>
    public interface IRepository<TEntity> : IWriteRepository<TEntity>,IReadRepository<TEntity> 
        where TEntity:Entity<TEntity>,new()
    {
        /// <summary>
        /// Gets the a <see cref="Transactions.IUnitOfWork"/> of <typeparamref name="T"/> that
        /// the repository will use to query the underlying store.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Transactions.IUnitOfWork"/> implementation to retrieve.</typeparam>
        /// <returns>The <see cref="Transactions.IUnitOfWork"/> implementation.</returns>
        T UnitOfWork<T>() where T : Transactions.IUnitOfWork;
        
    }
}