
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mConstruct_WebApi
{
    public class SecureActionFilterAttribute : TypeFilterAttribute
    {
        public SecureActionFilterAttribute()
                             : base(typeof(SecureActionFilterImpl))
        {
        }

        private class SecureActionFilterImpl : IActionFilter
        {
            private readonly ILogger _logger;
            public SecureActionFilterImpl(ILoggerFactory loggerFactory)
            {
                _logger = loggerFactory.CreateLogger<SecureActionFilterAttribute>();
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                _logger.LogInformation("SecureActionFilterAttribute.OnActionExecuting");
                // convert string to stream
                byte[] byteArray = Encoding.UTF8.GetBytes("HELLO");
                //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                MemoryStream stream = new MemoryStream(byteArray);
                context.HttpContext.Request.Body = stream;

            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
                _logger.LogInformation("SecureActionFilterAttribute.OnActionExecuted");
            }
        }
    }
}
