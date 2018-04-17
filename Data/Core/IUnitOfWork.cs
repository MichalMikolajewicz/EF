using Data.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core
{
	public interface IUnitOfWork : IDisposable
	{
		IPersonRepository People { get; }
		int Complete();
	}
}
