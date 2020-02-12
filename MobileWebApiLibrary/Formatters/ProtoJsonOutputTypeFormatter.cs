using Google.Protobuf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MobileWebApiLibrary.Formatters
{
    public class ProtoJsonOutputTypeFormatter : OutputFormatter
    {

        public ProtoJsonOutputTypeFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/proto+json"));
        }

        protected override bool CanWriteType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (type.GetInterface("IMessage") == typeof(IMessage))
                return true;

            return false;
        }

        public override Task WriteAsync(OutputFormatterWriteContext context)
        {
            if (context.Object is IMessage)
            {
                var response = context.HttpContext.Response;
                return response.WriteAsync((context.Object as IMessage).ToString());
            }

            return null;
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            if (context.Object is IMessage)
            {
                var response = context.HttpContext.Response;
                return response.WriteAsync((context.Object as IMessage).ToString());
            }

            return null;
        }
    }
}
