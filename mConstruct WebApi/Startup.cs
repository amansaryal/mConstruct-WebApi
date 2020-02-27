using mConstruct_WebApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MobileWebApiLibrary.Formatters;
using MobileWebApiLibrary.Middlewares;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using Newtonsoft.Json;
using System.Buffers;
using mConstruct_WebApi.Middlewares;

namespace mConstruct_WebApi
{
    public class Startup
    {
        private readonly ILogger<Startup> logger;

        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;          
            this.logger = logger;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(
                options =>
                {

                    //init JsonInputFormatter

                    ObjectPoolProvider _objectPoolProvider = new DefaultObjectPoolProvider();
                    JsonSerializerSettings _serializerSettings = new JsonSerializerSettings();
                    var myFormatter = new MyJsonInputFormatter(
                        logger,
                        _serializerSettings,
                        ArrayPool<char>.Shared,
                        _objectPoolProvider,
                        new MvcOptions(),
                        new MvcJsonOptions());

                    options.InputFormatters.Insert(1, myFormatter);
                    options.InputFormatters.Add(new ProtobufInputTypeFormatter());
                    options.OutputFormatters.Add(new ProtobufOutputTypeFormatter());
                    options.OutputFormatters.Add(new ProtoJsonOutputTypeFormatter());
                }
                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddApiVersioning();

            services.AddDbContext<PlngDbContext>(optionsAction => {
                optionsAction.UseOracle(Configuration.GetConnectionString("PlanningDatabase"));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {

            }
            else
            {
                app.UseHsts();

            }

            if (env.IsEnvironment("Local"))
                app.UsePathBase("/mConstructApi");

            app.UseExceptionHandler("/error");

            app.UseHttpsRedirection();

            app.UseMiddleware<AuthenticationMiddleware>();        

            app.UseMiddleware<SecurityMiddleware>();

            app.UseMiddleware<MyExceptionHandlerAndLoggerMiddleware>();

            app.UseMvc();

        }
    }
}
