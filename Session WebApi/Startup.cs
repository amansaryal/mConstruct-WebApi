using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MobileWebApiLibrary.Formatters;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Middlewares;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Routing;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using System.Linq;
using MobileWebApiLibrary.Swagger;

namespace Session_WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _currentEnvironment = env;
            Configuration = configuration;            
        }

        private readonly IHostingEnvironment _currentEnvironment;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(
                options =>
                {
                    options.Filters.Add(new HttpResponseExceptionFilter(_currentEnvironment));
                    options.InputFormatters.Add(new ProtobufInputTypeFormatter());
                    options.OutputFormatters.Add(new ProtobufOutputTypeFormatter());                   
                    options.OutputFormatters.Add(new ProtoJsonOutputTypeFormatter());                   
                }            
                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddApiVersioning();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Session Api v1", Version = "v1" });

                // This call remove version from parameter, without it we will have version as parameter 
                // for all endpoints in swagger UI
                options.OperationFilter<RemoveVersionFromParameter>();

                // This make replacement of v{version:apiVersion} to real version of corresponding swagger doc.
                options.DocumentFilter<ReplaceVersionWithExactValueInPath>();

                //This tells swagger what all actions are to be shown in the given version
                options.DocInclusionPredicate((docName, apiDesc) =>
                 {                    
                     if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo)) return false;

                     var versions = methodInfo.DeclaringType
                         .GetCustomAttributes(true)
                         .OfType<ApiVersionAttribute>()
                         .SelectMany(attr => attr.Versions);

                     return versions.Any(v => $"v{v.ToString()}" == docName);
                 });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/error");
            }
            else
            {
                app.UseHsts();
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseMiddleware<SecurityMiddleware>();

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Session Api v1");
            });
        }
    }
}
