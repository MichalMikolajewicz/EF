using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Data.Core;
using Data.Persistence;
using Service.Contracts;
using Service.Implementations;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Service.Configurations.DependencyInjection;

namespace Presentation
{
    public class Startup
    {
		private Container container = BusinessContainer.container;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
			IntegrateSimpleInjector(services);

			//var connection = @"Server=MICHAL\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;";
			//services.AddDbContext<AdventureWorks2014Context>(options => options.UseSqlServer(connection));
			//services.AddScoped<IUnitOfWork, UnitOfWork>();
			//services.AddScoped<IPersonService, PersonService>();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			InitializeContainer(app);
			

			container.Verify();

			if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }

		private void IntegrateSimpleInjector(IServiceCollection services)
		{
			//container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddSingleton<IControllerActivator>(
				new SimpleInjectorControllerActivator(container));
			services.AddSingleton<IViewComponentActivator>(
				new SimpleInjectorViewComponentActivator(container));

			services.EnableSimpleInjectorCrossWiring(container);
			services.UseSimpleInjectorAspNetRequestScoping(container);
		}

		private void InitializeContainer(IApplicationBuilder app)
		{
			// Add application presentation components:
			container.RegisterMvcControllers(app);
			container.RegisterMvcViewComponents(app);

			// Add application services. For instance:
			container.Register<IPersonService, PersonService>(Lifestyle.Scoped);

			// Allow Simple Injector to resolve services from ASP.NET Core.
			container.AutoCrossWireAspNetComponents(app);
		}
	}
}
