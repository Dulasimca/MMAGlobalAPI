using MMAGlobal.Application.Handlers.CommandHandlers;
using MMAGlobal.Core.Repositories;
using MMAGlobal.Core.Repositories.Base;
using MMAGlobal.Infrastructure.Data;
using MMAGlobal.Infrastructure.Repositories;
using MMAGlobal.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MMAGlobal.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<MMAGlobalTestContext>(
                m => m.UseSqlServer(Configuration.GetConnectionString("MMAGlobalDB")), ServiceLifetime.Singleton);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MMAGlobal.API", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(CreateMMAGlobalTestHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IMMAGlobalTestRepository, MMAGlobalTestRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MMAGlobal.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
