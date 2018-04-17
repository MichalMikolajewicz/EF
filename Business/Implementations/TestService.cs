using Business.Models;
using Persistance.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
	public class TestService
	{
		private readonly IUnitOfWork unitOfWork;
		public TestService(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;

		}

		public IEnumerable<PeopleModel> GetTestData()
		{
			var list = new List<PeopleModel>();

			unitOfWork.People.GetAll().Take(10).ToList().ForEach(x => list.Add(new PeopleModel
			{
				LastName = x.FirstName + " " + x.MiddleName,
				Name = x.LastName,
				Description = x.Password.PasswordHash
			}));

			return list;

		}

	}
}
