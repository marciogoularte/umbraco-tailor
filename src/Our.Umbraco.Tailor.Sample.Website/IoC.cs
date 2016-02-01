// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   Defines the IoC type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website
{
    using Autofac;

    /// <summary>
    /// The io c.
    /// </summary>
    public class IoC
    {
        /// <summary>
        /// Gets or sets the instance.
        /// </summary>
        public static IContainer Container { get; set; }
    }
}