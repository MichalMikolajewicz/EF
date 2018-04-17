using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance.Repositories
{
	public class SalesOrderHeaderSalesReasonRepository : Repository<SalesOrderHeaderSalesReason>
	{
		public SalesOrderHeaderSalesReasonRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
