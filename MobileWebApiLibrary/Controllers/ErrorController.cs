using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;

namespace MobileWebApiLibrary.Controllers
{
    //Controller to handle uncaught exceptions and write logs
    //Exceptions are re-packed with a problem details and sent as an error response
    [ApiExplorerSettings(IgnoreApi = true)]   
    public abstract class ErrorController : BaseController
    {
        [Route("/error")]
        public ActionResult Error([FromServices] IHostingEnvironment webHostEnvironment)
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var ex = feature?.Error;
            var isDev = webHostEnvironment.IsDevelopment();
            var problemDetails = new ProblemDetails
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Instance = isDev ? feature?.Path : null,
                Title = isDev ? $"{ex.GetType().Name}: {ex.Message}" : "Something went wrong",
                Detail = isDev ? ex.StackTrace : null,
            };

            if(webHostEnvironment.IsProduction()) logError(feature);

            return StatusCode(problemDetails.Status.Value, problemDetails);
        }

        protected abstract void logError(IExceptionHandlerPathFeature feature);       
    }
}
