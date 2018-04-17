﻿using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance.Repositories
{
	public class SalesReasonRepository : Repository<SalesReason>
	{
		public SalesReasonRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}
