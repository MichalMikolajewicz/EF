using Data.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core;
using Data.Models;
using Data.Core.Repositories;

namespace Data.Persistence
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AdventureWorks2014Context _context;
		public IPersonRepository People { get; private set; }

		public UnitOfWork(AdventureWorks2014Context context)
		{
			_context = context;
			People = new PersonRepository(context);
		}

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
