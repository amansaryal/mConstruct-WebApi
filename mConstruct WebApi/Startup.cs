using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Formatters;
using MobileWebApiLibrary.Middlewares;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace mConstruct_WebApi
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

            //api versioning conflicts with exception handler routes, thus disabling any and all kinds of global exception handling. hence it is disabled.
            //use explicit versioning in controller routes
            //but use the ApiVersioningAttribute to generate swagger doc as shown below
            //services.AddApiVersioning(); 

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Session Api v1", Version = "v1" });
                options.SwaggerDoc("v2", new OpenApiInfo { Title = "Session Api v2", Version = "v2" });

                //// This call removes version from parameter, without it we will have version as parameter 
                //// for all endpoints in swagger UI
                //options.OperationFilter<RemoveVersionFromParameter>(); //use when api versioning is enabled

                //// This replaces v{version:apiVersion} to real version of corresponding swagger doc.
                //options.DocumentFilter<ReplaceVersionWithExactValueInPath>(); //use when api versioning is enabled

                ////This tells swagger what all actions are to be shown in the given version
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
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", $"v1");
                c.SwaggerEndpoint($"/swagger/v2/swagger.json", $"v2");
            });
        }
    }
}
