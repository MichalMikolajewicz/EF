﻿using AutoMapper;
using Business.Configurations;
using Business.Contracts;
using Business.Implementations;
using Persistance.Core;
using Persistance.Persistence;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configurations
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
			container.Register<IConfigurationProvider>(() => new MapperConfiguration(cfg => { cfg.AddProfile<BusinessProfile>(); })); // first shit
			container.Register<InstanceMapper>();
			container.Register(() => container.GetInstance<InstanceMapper>().GetMapper()); // second shit,
			container.Register<IPeopleService, PeopleService>();
			container.Verify();
		}
	}
}
