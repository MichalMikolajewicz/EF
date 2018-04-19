﻿using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistance.Repositories
{
	public class ProductModelRepository : Repository<ProductModel>
	{
		public ProductModelRepository(AdventureWorks2014Context context) : base(context)
		{

		}
	}
}