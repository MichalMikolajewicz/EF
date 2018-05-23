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
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }
		public Container Container { get; private set; }
		private void SetupContainer()
		{
			var container = new Container();
			new BusinessContainer(container, Configuration);
			Container = container;
		}
		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			SetupContainer();
			services.AddMvc();
			IntegrateSimpleInjector(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			InitializeContainer(app);


			Container.Verify();

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
				new SimpleInjectorControllerActivator(Container));
			services.AddSingleton<IViewComponentActivator>(
				new SimpleInjectorViewComponentActivator(Container));

			services.EnableSimpleInjectorCrossWiring(Container);
			services.UseSimpleInjectorAspNetRequestScoping(Container);
		}

		private void InitializeContainer(IApplicationBuilder app)
		{
			// Add application presentation components:
			Container.RegisterMvcControllers(app);
			Container.RegisterMvcViewComponents(app);

			// Add application services. For instance:
			Container.Register<IPersonService, PersonService>(Lifestyle.Scoped);

			// Allow Simple Injector to resolve services from ASP.NET Core.
			Container.AutoCrossWireAspNetComponents(app);
		}
	}
}
