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
	public class Culture : Repository<Culture>
	{
		public Culture(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
