using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MobileWebApiLibrary.Formatters;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Middlewares;

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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Session Api", Version = "v1" });
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
