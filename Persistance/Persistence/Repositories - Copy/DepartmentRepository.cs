using Persistance.Core.Domain;
using Persistance.Persistence;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Core.Repositories
{
	public class Department : Repository<Department>
	{
		public Department(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
