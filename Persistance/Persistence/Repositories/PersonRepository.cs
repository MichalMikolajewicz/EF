using Persistance.Core.Domain;
using Persistance.Persistence;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Persistance.Core.Repositories
{
	public class PersonRepository : Repository<Person>, IPersonRepository
	{
		public PersonRepository(AdventureWorks2014Context context) : base(context)
		{

		}

		public Person GetFirstPersonWithEmailAddress()
		{
			return context.People.Where(x => x.EmailAddresses.FirstOrDefault(y => y.EmailAddress1 != null) != null).FirstOrDefault();
		}


		public object CartesianProductAndDistinct()
		{
			var shit = (from a in context.EmployeeDepartmentHistories
					   join b in context.Employees on a.BusinessEntityID equals b.BusinessEntityID into lol
					   from g1 in lol.DefaultIfEmpty()
					   join c in context.Departments on a.BusinessEntityID equals c.DepartmentID into lol2
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
			var selectManyTest = context.People.SelectMany(x => x.EmailAddresses).ToList();
			var test4 = context.EmailAddresses.ToList();

			var existTest = context.People.Where(x => context.People.Any(y => y.FirstName == "Mike")).ToList();
			var allTest = context.People.Where(x => context.People.All(y => y.FirstName == "Mike")).ToList();
			//i tak leci distinct
			var groupByAsDistinct = context.Employees.GroupBy(x => new { x.JobTitle, x.Gender })
				.Select(x => new { x.Key.Gender, x.Key.JobTitle, Count = x.Count() }).ToList();
			//create database model object using linq to entity generate error
			var name = context.People.Select(x => new Person
			{
				MiddleName = x.MiddleName

			}).ToList();
			var test = context.People.SelectMany(x => context.People, (x, y) => new { x.BusinessEntityID, x.PersonType })
				.Distinct();
			//test.ToList();
			return context.People.SelectMany(x => context.People, (x, y) => new
			{
				x.BusinessEntityID,
				x.PersonType
			})
				.Distinct().ToDictionary(x => x.BusinessEntityID, y => y.PersonType);
		}
	}
}
