using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System.IO;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Middlewares
{
    public class SecurityMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public SecurityMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("SecurityMiddleware");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("SecurityMiddleware executing..");

            //request enters the pipeline

            if (httpContext.Request.Headers.ContainsKey("X-Secure"))
            {

                StringValues x_secure_header_values = new StringValues();

                if (httpContext.Request.Headers.TryGetValue("X-Secure", out x_secure_header_values) && x_secure_header_values.ToString() == "true")
                {
                    //decrypt request
                    byte[] encryptedRequest = StreamHelper.ReadFully(httpContext.Request.Body);
                    byte[] decryptedRequest = EncryptionHelper.DecryptCode(encryptedRequest);

                    //write to request body
                    httpContext.Request.Body = new MemoryStream(decryptedRequest);

                    //swap response stream with readable stream
                    Stream originalStream = httpContext.Response.Body;

                    MemoryStream memoryStream = new MemoryStream();
                    httpContext.Response.Body = memoryStream;

                    await _next(httpContext);

                    // response exits the pipeline

                    memoryStream.Seek(0, SeekOrigin.Begin);

                    //encrypt response
                    byte[] encryptedResponse = EncryptionHelper.EncryptCode(StreamHelper.ReadFully(memoryStream));

                    memoryStream = new MemoryStream(encryptedResponse);

                    await memoryStream.CopyToAsync(originalStream);
                    
                    //replace original stream
                    httpContext.Response.Body = originalStream;
                }
            }

            await _next(httpContext);
        }       
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SecurityMiddlewareExtensions
    {
        public static IApplicationBuilder UseSecurityMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SecurityMiddleware>();
        }
    }
}
