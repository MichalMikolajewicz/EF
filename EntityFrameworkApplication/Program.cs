using Persistance.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Persistance.Core;
using SimpleInjector.Lifestyles;
using Business.Configurations;
using Business.Contracts;
using Business.Configurations.Implementations;

namespace EntityFrameworkApplication
{
	class Program
	{
		static void Main(string[] args)
		{

			var container = BusinessContainer.container;
			BusinessMapper.GetMapper();

			using (AsyncScopedLifestyle.BeginScope(container))
			{
				var service = container.GetInstance<IPeopleService>();
				
				var abc = service.GetPeoples();
			}
		}
	}

}
