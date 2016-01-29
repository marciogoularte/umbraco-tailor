// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonaRepository.cs" company="Umbrella Inc, Our Umbraco and other contributors">
//   Copyright Umbrella Inc, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The Persona repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Our.Umbraco.Tailor.Repositories.Interfaces;
    using Our.Umbraco.Tailor.Repositories.Models;

    /// <summary>
    /// The base repository.
    /// </summary>
    public abstract class PersonaRepository : IRepository<Persona>
    {
        /// <summary>
        /// The get persona from cookie
        /// </summary>
        /// <returns>
        /// The <see cref="Persona"/>.
        /// </returns>
        public Persona Get()
        {
            // TODO: get persona from cookie
            return null;
        }

        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Insert(Persona data)
        {
            // TODO: create new persona
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Save(Persona data)
        {
            // TODO: save persona into database
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Save(IList<Persona> data)
        {
            // TODO: save personas into database
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Delete(Persona data)
        {
            // TODO: remove personas from database
        }

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="predicate">
        /// The predicate.
        /// </param>
        /// <returns>
        /// The list of personas.
        /// </returns>
        public IEnumerable<Persona> Search(Expression<Func<Persona, bool>> predicate)
        {
            // TODO: search personas from database
            return null;
        }
    }
}
