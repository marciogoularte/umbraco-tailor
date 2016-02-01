// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TailorModule.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The Tailor Module.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor
{
    using Autofac;

    /// <summary>
    /// The tailor module.
    /// </summary>
    public class TailorModule : Module
    {
        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        protected override void Load(ContainerBuilder builder)
        {
            // builder.Register(c => new Car(c.Resolve<IDriver>())).As<IVehicle>();
        }
    }
}
