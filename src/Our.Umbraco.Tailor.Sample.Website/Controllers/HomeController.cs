// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Our.Umbraco.Tailor.Sample.Website.Controllers
{
    using System.Web.Mvc;

    using global::Umbraco.Web.Models;

    using Our.Umbraco.Ditto;
    using Our.Umbraco.Tailor.Sample.Website.Models.DocumentTypes;
    using Our.Umbraco.Tailor.Sample.Website.Models.Renders;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// The home.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Home(RenderModel model)
        {
            var home = model.As<Home>();

            var viewModel = new RenderPageBase<Home>(home);

            return this.View("~/Views/Home.cshtml", viewModel);
        }
    }
}