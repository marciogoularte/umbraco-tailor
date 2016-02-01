// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUmbracoContentEntity.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The UmbracoContentEntity interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Interfaces
{
    /// <summary>
    /// The UmbracoContentEntity interface.
    /// </summary>
    public interface IUmbracoContentEntity
    {
        /// <summary>
        /// Gets the document type alias.
        /// </summary>
        string DocumentTypeAlias { get; }

        /// <summary>
        /// Gets the url.
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Gets the level.
        /// </summary>
        int Level { get; }
    }
}
