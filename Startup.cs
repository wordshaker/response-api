using JustEat.StatsD;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace response_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var statsDConfig = new StatsDConfiguration{
                Host = "graphite"
            };
            var statsDPublisher = new StatsDPublisher(statsDConfig);

            app.Use(async (context, next) =>
            {
                using (var timer = statsDPublisher.StartTimer("thing"))
                {
                     await next();
                     timer.StatName = $"response-api.code.{context.Response.StatusCode}";                    
                }
            });

            app.UseMvc();
        }
    }
}