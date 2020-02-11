using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Message_Handlers
{
    class UMSAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public UMSAuthMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("UMSAuthMiddleware");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("UMSAuthMiddleware executing..");

            //add user authentication code                       

            await _next(httpContext);
        }
    }
}
