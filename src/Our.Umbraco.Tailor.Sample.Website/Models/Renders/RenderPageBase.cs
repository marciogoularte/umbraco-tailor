// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RenderPageBase.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The render page base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Models.Renders
{
    using System.Globalization;

    using global::Umbraco.Web;

    /// <summary>
    /// The render page base.
    /// </summary>
    /// <typeparam name="T">
    /// Page type.
    /// </typeparam>
    public class RenderPageBase<T>
        where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderPageBase{T}"/> class.
        /// </summary>
        /// <param name="content">
        /// The content.
        /// </param>
        /// <param name="culture">
        /// The culture.
        /// </param>
        public RenderPageBase(T content, CultureInfo culture)
        {
            this.Content = content;
            this.CurrentCulture = culture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderPageBase{T}"/> class.
        /// </summary>
        /// <param name="content">
        /// The content.
        /// </param>
        public RenderPageBase(T content)
        {
            this.Content = content;
            this.CurrentCulture = UmbracoContext.Current.PublishedContentRequest.Culture;
        }

        /// <summary>
        /// Gets the content.
        /// </summary>
        public T Content { get; private set; }

        /// <summary>
        /// Gets the current culture.
        /// </summary>
        public CultureInfo CurrentCulture { get; private set; }
    }
}