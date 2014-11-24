﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace MFramework.Domain.Services.Repository.Select
{
    /// <summary>
    /// Order by clause implementation
    /// Used to sort the data
    /// </summary>
    /// <typeparam name="T">Type of DbSet to sort</typeparam>
    /// <typeparam name="TProperty">Property type to sort on</typeparam>
    public class OrderByClause<TEntity, TProperty> : IOrderByClause<TEntity>
        where TEntity : Entity<TEntity>, new()
    {
        /// <summary>
        /// New instance of sort by
        /// </summary>
        /// <param name="orderBy">Order by clause</param>
        /// <param name="sortDirection">Sort direction</param>
        public OrderByClause(
          Expression<Func<TEntity, TProperty>> orderBy,
          SortDirection sortDirection = SortDirection.Ascending)
        {
            OrderBy = orderBy;
            SortDirection = sortDirection;
        }

        /// <summary>
        /// Order by expression
        /// </summary>
        private Expression<Func<TEntity, TProperty>> OrderBy { get; set; }

        /// <summary>
        /// Sort direction
        /// </summary>
        private SortDirection SortDirection { get; set; }

        /// <summary>
        /// Apply sort to IQueryable or IOrderedQueryable
        /// </summary>
        /// <param name="query">Query to sort</param>
        /// <param name="firstSort">Is this the very first sort</param>
        /// <returns></returns>
        public IOrderedQueryable<TEntity> ApplySort(IQueryable<TEntity> query, bool firstSort)
        {
            //ascending
            if (SortDirection == SortDirection.Ascending)
            {
                if (firstSort)
                {
                    return query.OrderBy(OrderBy);
                }
                //non-first sort
                return ((IOrderedQueryable<TEntity>)query).ThenBy(OrderBy);
            }
            //descending
            if (firstSort)
            {
                return query.OrderByDescending(OrderBy);
            }
            //non-first sort
            return ((IOrderedQueryable<TEntity>)query).ThenByDescending(OrderBy);
        }
    }
}
