using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Repositories;

namespace Data.Persistance.Repositories
{
	public class PersonRepository : Repository<Person>, IPersonRepository
	{
		public PersonRepository(AdventureWorks2014Context context) : base(context)
		{

		}

		public Person GetFirstPersonWithEmailAddress()
		{
			return context.Person.Where(x => x.EmailAddress.FirstOrDefault(y => y.EmailAddress1 != null) != null).FirstOrDefault();
		}


		public object CartesianProductAndDistinct()
		{
			var shit = (from a in context.EmployeeDepartmentHistory
					   join b in context.Employee on a.BusinessEntityId equals b.BusinessEntityId into lol
					   from g1 in lol.DefaultIfEmpty()
					   join c in context.Department on a.BusinessEntityId equals c.DepartmentId into lol2
					   from g2 in lol2.DefaultIfEmpty()
					   select new { g1, g2 }).ToList();





			//Return in console sql statement execute on database 
			//context.Database.Log = Console.Write;
			//bad
			var test1 = context.Logs
	 .SelectMany(x => context.Logs
		 .SelectMany(z => context.Logs,
		 (z, c) => new { x, c }),
	 (x, y) => new { x, y });//.ToList();
							 //better
			var test2 = context.Logs
			.SelectMany(x => context.Logs, (x, y) => new { x, y })
			.SelectMany(temp => context.Logs, (temp, z) => new { temp.x, temp.y, z });
			//selectManyTest and test4 generate same sql
			var selectManyTest = context.Person.SelectMany(x => x.EmailAddress).ToList();
			var test4 = context.EmailAddress.ToList();

			var existTest = context.Person.Where(x => context.Person.Any(y => y.FirstName == "Mike")).ToList();
			var allTest = context.Person.Where(x => context.Person.All(y => y.FirstName == "Mike")).ToList();
			//i tak leci distinct
			var groupByAsDistinct = context.Employee.GroupBy(x => new { x.JobTitle, x.Gender })
				.Select(x => new { x.Key.Gender, x.Key.JobTitle, Count = x.Count() }).ToList();

			var test = context.Person.SelectMany(x => context.Person, (x, y) => new { x.BusinessEntityId, x.PersonType })
				.Distinct();
			//test.ToList();
			return context.Person.SelectMany(x => context.Person, (x, y) => new
			{
				x.BusinessEntityId,
				x.PersonType
			})
				.Distinct().ToDictionary(x => x.BusinessEntityId, y => y.PersonType);
		}
	}
}
