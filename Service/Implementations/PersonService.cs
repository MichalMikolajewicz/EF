using AutoMapper;
using Data.Core;
using Data.Models;
using Models.BusinessModels;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Implementations
{
	public class PersonService : IPersonService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public PersonService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}

		public IEnumerable<PersonModel> GetPeople()
		{
			var list = new List<PersonModel>();

			unitOfWork.People.GetAll().ToList().ForEach(x => list.Add(mapper.Map<Person, PersonModel>(x)));

			return list;
		}
	}
}
