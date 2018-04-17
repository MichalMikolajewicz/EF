using Data.Models;
using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance.Repositories
{
	public class ShiftRepository : Repository<Shift>
	{
		public ShiftRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
