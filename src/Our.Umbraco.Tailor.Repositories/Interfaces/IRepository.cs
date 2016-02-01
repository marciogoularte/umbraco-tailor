// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Repositories.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// Type of entity.
    /// </typeparam>
    public interface IRepository<TEntity>
        where TEntity : class, IDisposable
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        TEntity Get();

        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        void Insert(TEntity data);

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        void Save(TEntity data);

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        void Save(IList<TEntity> data);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        void Delete(TEntity data);

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="predicate">
        /// The predicate.
        /// </param>
        /// <returns>
        /// The list of search result.
        /// </returns>
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
