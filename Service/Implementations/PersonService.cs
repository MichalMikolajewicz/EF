using Data.Core;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementations
{
	public class PersonService : IPersonService
	{
		private readonly IUnitOfWork unitOfWork;

		public PersonService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		
	}
}
