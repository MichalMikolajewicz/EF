using AutoMapper;
using Business.Contracts;
using Business.Models;
using Persistance.Core;
using Persistance.Core.Domain;
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
		private readonly IMapper mapper;
		public PeopleService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}

		public IEnumerable<PeopleModel> GetPeoples()
		{
			var list = new List<PeopleModel>();

			unitOfWork.People.GetAll().ToList().ForEach(x => list.Add(mapper.Map<Person, PeopleModel>(x)));

			return list;

		}
	}
}
