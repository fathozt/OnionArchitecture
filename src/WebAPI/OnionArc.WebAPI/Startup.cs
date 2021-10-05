using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OnionArc.Application.Features.Queries.GetAllProducts;
using OnionArc.Application.Interfaces.Repositories;
using OnionArc.Persistence.Context;
using OnionArc.Persistence.Repositories;
using System.IO;

namespace OnionArc.WebAPI
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
            services.AddControllers();
            //services.AddPersistenceServices();
            services.AddDbContext<OnionArcDbContext>(opt => opt.UseSqlServer());
            services.AddAutoMapper(typeof(GetAllProductQueryResponse).Assembly);
            services.AddMediatR(typeof(GetAllProductQueryRequest).Assembly);
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            //services.AddTransient<IImageRepository, ImageRepository>();
            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OnionArc.WebAPI", Version = "v1" });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, $"OnionArc.WebAPI.xml");
                c.IncludeXmlComments(filePath);
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OnionArc.WebAPI v1"));
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
