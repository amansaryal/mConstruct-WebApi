using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System.IO;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LoggerMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("LoggerMiddleware");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("LoggerMiddleware executing..");
            await _next(httpContext);

            //response exits
        }       
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }
    }
}
