using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace MobileWebApiLibrary.Swagger
{
    public class ReplaceVersionWithExactValueInPath : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            if (swaggerDoc == null)
                throw new ArgumentNullException(nameof(swaggerDoc));

            var replacements = new OpenApiPaths();

            foreach (KeyValuePair<string, OpenApiPathItem> openApiPath in swaggerDoc.Paths)
            {
                replacements.Add(openApiPath.Key.Replace("v{version}", swaggerDoc.Info.Version), openApiPath.Value);
            }

            swaggerDoc.Paths = replacements;
        }
    }
}
