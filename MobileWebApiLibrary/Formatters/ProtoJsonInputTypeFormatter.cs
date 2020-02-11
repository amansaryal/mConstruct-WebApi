using Google.Protobuf;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MobileWebApiLibrary
{
    public class ProtoJsonInputTypeFormatter : InputFormatter
    {

        public ProtoJsonInputTypeFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
        }

        protected override bool CanReadType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (type.GetInterface("IMessage") == typeof(IMessage))
                return true;

            return false;
        }

        public override Task<InputFormatterResult> ReadAsync(InputFormatterContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var request = context.HttpContext.Request;


                try
                {
                    ConstructorInfo typeConstructor = context.ModelType.GetConstructor(Type.EmptyTypes);

                    object typeClassObject = typeConstructor.Invoke(new object[] { });

                    MessageParser parserObject = (typeClassObject.GetType().GetProperty("Parser").GetGetMethod().Invoke(typeClassObject, null) as MessageParser);



                    return InputFormatterResult.SuccessAsync(parserObject.ParseJson(new StreamReader(request.Body).ReadToEnd()));

                }
                catch
                {
                    return InputFormatterResult.FailureAsync();
                }
            
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var request = context.HttpContext.Request;


            try
            {
                ConstructorInfo typeConstructor = context.ModelType.GetConstructor(Type.EmptyTypes);

                object typeClassObject = typeConstructor.Invoke(new object[] { });

                MessageParser parserObject = (typeClassObject.GetType().GetProperty("Parser").GetGetMethod().Invoke(typeClassObject, null) as MessageParser);



                return InputFormatterResult.SuccessAsync(parserObject.ParseJson(new StreamReader(request.Body).ReadToEnd()));

            }
            catch
            {
                return InputFormatterResult.FailureAsync();
            }

        }
    }
}
