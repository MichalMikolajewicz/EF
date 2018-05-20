using AutoMapper;
using Data.Core;
using Data.Models;
using Data.Persistence;
using Service.Contracts;
using Service.Implementations;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Configurations.DependencyInjection
{
    public static class BusinessContainer
    {
		public static readonly Container container;

		static BusinessContainer()
		{
			container = new Container();
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<AdventureWorks2014Context>(Lifestyle.Scoped);
			container.Register<IConfigurationProvider>(() => new MapperConfiguration(cfg => { cfg.AddProfile<BusinessProfile>(); })); // how to do this better?
			container.Register<InstanceMapper>();
			container.Register(() => container.GetInstance<InstanceMapper>().GetMapper()); // how to do this better?
			container.Register<IPersonService, PersonService>();
			container.Verify();
		}
	}
}
