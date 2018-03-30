using Persistance.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Core
{
	public interface IUnitOfWork : IDisposable
	{
		IPersonRepository People { get; }
		int Complete();
	}
}
