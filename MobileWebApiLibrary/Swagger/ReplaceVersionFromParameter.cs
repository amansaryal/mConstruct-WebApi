using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MobileWebApiLibrary.Swagger
{
    public class RemoveVersionFromParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            foreach (var parameter in operation.Parameters)
            {
                if (parameter.Name.Equals("Version", System.StringComparison.OrdinalIgnoreCase))
                {
                    operation.Parameters.Remove(parameter);
                    return;
                }
            }
        }
    }
}
