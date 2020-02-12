using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Message_Handlers
{
    public class SecurityHandlerMiddleware : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Contains("X-Secure") && request.Headers.GetValues("X-Secure").GetEnumerator().Current.Equals("true"))
            {
                //decrypt request
                byte[] encryptedRequest = request.Content.ReadAsByteArrayAsync().Result;
                byte[] decryptedRequest = EncryptionHelper.DecryptCode(encryptedRequest);

                ByteArrayContent requestContent = new ByteArrayContent(decryptedRequest);
                request.Content = requestContent;

                var response = base.SendAsync(request, cancellationToken);


                //encrypt response
                byte[] plainResponse = response.Result.Content.ReadAsByteArrayAsync().Result;
                byte[] encryptedResponse = EncryptionHelper.EncryptCode(plainResponse);

                ByteArrayContent responseContent = new ByteArrayContent(encryptedResponse);
                request.Content = responseContent;

                return response;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
