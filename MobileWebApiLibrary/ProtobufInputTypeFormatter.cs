using Google.Protobuf;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MobileWebApiLibrary
{
    public class ProtobufInputTypeFormatter : InputFormatter
    {

        public ProtobufInputTypeFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/plain"));
        }

        protected override bool CanReadType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (type == typeof(IMessage))
                return true;
            return false;
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var request = context.HttpContext.Request;

            using (var reader = new StreamReader(request.Body))
            {
                try
                {
                    ConstructorInfo typeConstructor = context.ModelType.GetConstructor(Type.EmptyTypes);

                    object typeClassObject = typeConstructor.Invoke(new object[] { });

                    object parserObject = typeClassObject.GetType().GetMethod("Parser").Invoke(typeClassObject, null);


                    return InputFormatterResult.SuccessAsync(parserObject.GetType().GetMethod("ParseFrom").Invoke(parserObject, new object[] { reader }));

                }
                catch
                {
                    return InputFormatterResult.FailureAsync();
                }
            }
        }
    }
}
