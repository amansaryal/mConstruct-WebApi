using Google.Protobuf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MobileWebApiLibrary
{
    public class ProtobufOutputTypeFormatter : OutputFormatter
    {

        public ProtobufOutputTypeFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/plain"));
        }

        protected override bool CanWriteType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (typeof(IMessage).IsAssignableFrom(type))
                return true;
            return false;
        }


        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {

            var response = context.HttpContext.Response;

            Stream responseStream = new MemoryStream();

            if(context.Object is IMessage)
            {
                context.ObjectType.GetMethod("WriteTo").Invoke(context.Object, new object[] { new CodedOutputStream(responseStream) });
            }

            return response.WriteAsync(new StreamReader(responseStream).ReadToEnd());
        }
    }
}
