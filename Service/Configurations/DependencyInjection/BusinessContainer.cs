using AutoMapper;
using Data.Core;
using Data.Models;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service.Contracts;
using Service.Implementations;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Configurations.DependencyInjection
{
    public class BusinessContainer
    {
		public BusinessContainer(Container container, IConfiguration configuration)
		{
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Register(() => new DbContextOptionsBuilder<AdventureWorks2014Context>().UseSqlServer(configuration.GetConnectionString("DefaultConnection")).Options, Lifestyle.Scoped);
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<AdventureWorks2014Context>(Lifestyle.Scoped);
			container.Register<AutoMapper.IConfigurationProvider>(() => new MapperConfiguration(cfg => { cfg.AddProfile<BusinessProfile>(); }), Lifestyle.Scoped); // how to do this better?
			container.Register<InstanceMapper>();
			container.Register(() => container.GetInstance<InstanceMapper>().GetMapper(), Lifestyle.Scoped); // how to do this better?
		}
	}
}
