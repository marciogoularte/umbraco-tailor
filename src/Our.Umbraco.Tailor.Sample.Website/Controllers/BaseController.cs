// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseController.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The base controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Controllers
{
    using System.Collections.Generic;

    /// <summary>
    /// The base controller.
    /// </summary>
    public class BaseController : SurfaceRenderMvcController
    {
        /// <summary>
        /// Gets the excluded document type aliases.
        /// </summary>
        public static ICollection<string> ExcludedDoctypeAliases { get; } = new List<string>();
    }
}