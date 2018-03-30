using Persistance.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var unitOfWork = new UnitOfWork(new AdventureWorks2014Context()))
			{
				var abc = unitOfWork.People.CartesianProductAndDistinct();
			}
			
		}
	}
}
