using Business.Contracts;
using Business.Models;
using Persistance.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
	public class PeopleService : IPeopleService
	{
		private readonly IUnitOfWork unitOfWork;

		public PeopleService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		IEnumerable<PeopleModel> GetPeoples()
		{
			var list = new List<PeopleModel>();
			unitOfWork.People.GetAll().ToList().ForEach(x => list.Add(new PeopleModel
			{
				Description = x.Password.PasswordHash,
				LastName = x.LastName,
				Name = x.FirstName + " " + x.MiddleName
			}));

			return list;

		}
	}
}
