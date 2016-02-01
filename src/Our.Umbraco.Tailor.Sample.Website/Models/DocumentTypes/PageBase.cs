// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PageBase.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   Defines the PageBase type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Models.DocumentTypes
{
    using System;
    using System.ComponentModel;

    using Interfaces;

    using Our.Umbraco.Ditto;

    /// <summary>
    /// The page base.
    /// </summary>
    [TypeConverter(typeof(DittoPickerConverter))]
    public class PageBase : IPageBase
    {
        /// <summary>
        /// Gets or sets the document type alias.
        /// </summary>
        public string DocumentTypeAlias { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}