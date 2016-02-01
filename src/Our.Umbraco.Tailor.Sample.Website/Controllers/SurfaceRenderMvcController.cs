// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SurfaceRenderMvcController.cs" company="ZHEN YUAN, Our Umbraco and other contributors">
//   Copyright ZHEN YUAN, Our Umbraco and other contributors
// </copyright>
// <summary>
//   The surface render mvc controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.Tailor.Sample.Website.Controllers
{
    using System.Configuration;
    using System.Web;
    using System.Web.Configuration;
    using System.Web.Mvc;

    using global::Umbraco.Core.Logging;
    using global::Umbraco.Web.Models;
    using global::Umbraco.Web.Mvc;

    /// <summary>
    /// The surface render mvc controller.
    /// </summary>
    public class SurfaceRenderMvcController : SurfaceController, IRenderMvcController
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index(RenderModel model)
        {
            return this.CurrentTemplate(model);
        }

        /// <summary>
        /// The current template.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        protected ActionResult CurrentTemplate<T>(T model)
        {
            var str = this.ControllerContext.RouteData.Values["action"].ToString();

            if (!this.EnsurePhysicalViewExists(str))
            {
                return this.Content(string.Empty);
            }

            return this.View(str, model);
        }

        /// <summary>
        /// The ensure physical view exists.
        /// </summary>
        /// <param name="template">
        /// The template.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        protected bool EnsurePhysicalViewExists(string template)
        {
            if (ViewEngines.Engines.FindView(this.ControllerContext, template, null).View != null)
            {
                return true;
            }

            LogHelper.Warn<SurfaceRenderMvcController>("No physical template file was found for template " + template);
            return false;
        }

        /// <summary>
        /// The on exception.
        /// </summary>
        /// <param name="filterContext">
        /// The filter context.
        /// </param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (((CompilationSection)ConfigurationManager.GetSection("system.web/compilation")).Debug
                || filterContext.ExceptionHandled)
            {
                return;
            }

            LogHelper.Error<SurfaceRenderMvcController>("Surface Render Mvc Controller Error", filterContext.Exception);

            HttpException httpException = filterContext.Exception as HttpException;

            if (httpException != null)
            {
                int httpCode = httpException.GetHttpCode();
                filterContext.HttpContext.Response.StatusDescription = httpException.Message;
                filterContext.HttpContext.Response.StatusCode = httpCode;
            }

            filterContext.Result = this.View("Error");
            filterContext.ExceptionHandled = true;
        }
    }
}