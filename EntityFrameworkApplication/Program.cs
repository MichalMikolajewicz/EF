using Persistance.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Persistance.Core;
using SimpleInjector.Lifestyles;

namespace EntityFrameworkApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			var container = Simple.container;

			using (ThreadScopedLifestyle.BeginScope(container))
			{
				var uow1 = container.GetInstance<IUnitOfWork>();
				var abc = uow1.People.CartesianProductAndDistinct();
			}
		}
	}

	static class Simple
	{
		public static readonly Container container;

		static Simple()
		{
			container = new Container();
			container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<AdventureWorks2014Context>(Lifestyle.Scoped);

			container.Verify();
		}
	}
}
