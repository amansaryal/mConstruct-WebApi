﻿using Google.Protobuf;
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
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/x-protobuf"));
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



                    return InputFormatterResult.SuccessAsync(parserObject.ParseFrom(ReadFully(request.Body)));

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



                return InputFormatterResult.SuccessAsync(parserObject.ParseFrom(ReadFully(request.Body)));

            }
            catch
            {
                return InputFormatterResult.FailureAsync();
            }
        }

        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}