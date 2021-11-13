using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaWebTatuajes.EnviarCorreos;
using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Mappers;
using SistemaWebTatuajes.Repository;
using SistemaWebTatuajes.Service;
using SistemaWebTatuajes.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes
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
            services.AddControllersWithViews();

            /*UTILIDADES*/
            services.AddScoped<IEncriptar, Encriptar>();
            /*LOGICA DE NEGOCIO*/
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();
            services.AddScoped<IUsuariosService, UsuariosService>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IMasterEmail, MasterEmail>();
            services.AddScoped<IPromocionService, PromocionService>();
            services.AddScoped<IPromocionRepository, PromocionRepository>();
            services.AddScoped<IArtistaService, ArtistaService>();
            services.AddScoped<IArtistaRepository, ArtistaRepository>();
            services.AddScoped<ITatuajeRepository, TatuajeRepository>();
            services.AddScoped<ITatuajeService, TatuajeService>();
            services.AddScoped<ICalificaService, CalificaService>();
            services.AddScoped<ICalificaRepository, CalificaRepository>();
            /*REGISTRO DE MAPPER*/
            var mapperConfig = new MapperConfiguration(mapper => { mapper.AddProfile(new MappingProfile()); });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            /*SEGURIDAD MEDIANTE COOKIES*/
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => { 
                options.LoginPath = "/Security/Index"; 
                options.AccessDeniedPath = "/Security/Permisos";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true; });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); } else { app.UseExceptionHandler("/Home/Error"); }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
