using AutoMapper;
using Data.Core;
using Data.Models;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
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
			var connection = @"Server=MICHAL\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;"; // baaaad - only for tests
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Register(() => new DbContextOptionsBuilder<AdventureWorks2014Context>().UseSqlServer(connection).Options,Lifestyle.Scoped);
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<AdventureWorks2014Context>(Lifestyle.Scoped);
			container.Register<IConfigurationProvider>(() => new MapperConfiguration(cfg => { cfg.AddProfile<BusinessProfile>(); }),Lifestyle.Scoped); // how to do this better?
			container.Register<InstanceMapper>();
			container.Register(() => container.GetInstance<InstanceMapper>().GetMapper(), Lifestyle.Scoped); // how to do this better?
		}
	}
}
