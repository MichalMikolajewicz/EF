using Persistance.Core.Domain;
using Persistance.Persistence.Repositories;
using Persistance.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Core.Repositories
{
	public class PasswordRepository : Repository<Password>
	{
		public PasswordRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
