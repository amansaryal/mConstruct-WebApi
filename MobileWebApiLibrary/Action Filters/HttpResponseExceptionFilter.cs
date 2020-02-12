using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MobileWebApiLibrary.Action_Filters
{
    //Exception filter to handle explicitly thrown exceptions
    //Thrown exception must be of HttpResponseException type

    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public HttpResponseExceptionFilter(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public int Order { get; set; } = int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is HttpResponseException exception)
            {
                if(exception.Value is ProblemDetails problemDetails && hostingEnvironment.IsProduction())
                {
                    problemDetails.Instance = null;

                }
                context.Result = new ObjectResult(exception.Value)
                {
                    StatusCode = exception.Status,
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
