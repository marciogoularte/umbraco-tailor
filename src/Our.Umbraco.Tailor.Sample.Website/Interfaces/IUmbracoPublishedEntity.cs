// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUmbracoPublishedEntity.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The UmbracoPublishedEntity interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Interfaces
{
    using System;

    /// <summary>
    /// The UmbracoPublishedEntity interface.
    /// </summary>
    public interface IUmbracoPublishedEntity
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the create date.
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the update date.
        /// </summary>
        DateTime UpdateDate { get; }
    }
}
