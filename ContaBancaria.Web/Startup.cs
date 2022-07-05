using ContaBancaria.Domain.Interfaces;
using ContaBancaria.Infra.Contexto;
using ContaBancaria.Infra.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Repositorios;

namespace ContaBancaria.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var connectionStrings = Configuration.GetConnectionString("ContaBancariaDB");
            services.AddDbContext<ContaBancariaContexto>(options =>
                                                    options
                                                    .UseLazyLoadingProxies()
                                                    .UseSqlServer(connectionStrings, m => m.MigrationsAssembly("ContaBancaria.Infra")));
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IContaCorrente, ContaCorrenteRepositorio>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
