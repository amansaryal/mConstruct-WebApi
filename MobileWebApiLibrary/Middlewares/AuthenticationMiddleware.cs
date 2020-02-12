using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Middlewares
{
    class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public AuthenticationMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("AuthenticationMiddleware");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("AuthenticationMiddleware executing..");

            //add user authentication code                       

            await _next(httpContext);
        }
    }
}
