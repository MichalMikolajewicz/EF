using Data.Models;
using Persistance.Persistence.Repositories;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance.Repositories
{
	public class PasswordRepository : Repository<Password>
	{
		public PasswordRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
