// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Home.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The home.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Models.DocumentTypes
{
    using Our.Umbraco.Ditto;

    /// <summary>
    /// The home.
    /// </summary>
    public class Home : PageBase
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [UmbracoProperty("title")]
        public string Title { get; set; }
    }
}