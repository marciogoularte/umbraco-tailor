// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   Defines the MvcApplication type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website
{
    using System;
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Autofac;
    using Autofac.Integration.Mvc;
    using Autofac.Integration.WebApi;

    using global::Umbraco.Web;

    using Our.Umbraco.Tailor.Sample.Website.Controllers;

    /// <summary>
    /// The mvc application.
    /// </summary>
    public class Global : UmbracoApplication
    {
        /// <summary>
        /// The on application started.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();

            // Register umbraco context, mvc controllers and api controllers
            builder.Register(c => UmbracoContext.Current).AsSelf();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(typeof(UmbracoApplication).Assembly);

            // Custom controller
            builder.RegisterApiControllers(typeof(HomeController).Assembly);

            // Register application specific types 
            this.RegisterTypes(builder);

            IoC.Container = builder.Build();

            var container = IoC.Container;

            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// The register types.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        private void RegisterTypes(ContainerBuilder builder)
        {
            //builder.RegisterType<THFSettings>().As<ISystemSettings>();
        }

        /// <summary>
        /// The register router.
        /// </summary>
        private void RegisterRouter()
        {
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional });
            });
        }
    }
}
