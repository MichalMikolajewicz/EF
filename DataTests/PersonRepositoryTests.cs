using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using Data.Models;
using Data.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DataTests
{
	public class PersonRepositoryTests
	{
		//How to improve this?
		[Fact]
		public void Should_Run_GetAll()
		{
			var optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2014Context>();
			var connection = @"Server=MICHAL\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;";
			optionsBuilder.UseSqlServer(connection);

			var contextMock = new Mock<AdventureWorks2014Context>(optionsBuilder.Options);
			var people = new List<Person> { new Person { BusinessEntityId = 1 } };

			var queryable = people.AsQueryable();

			var dbSet = new Mock<DbSet<Person>>();
			dbSet.As<IQueryable<Person>>().Setup(m => m.Provider).Returns(queryable.Provider);
			dbSet.As<IQueryable<Person>>().Setup(m => m.Expression).Returns(queryable.Expression);
			dbSet.As<IQueryable<Person>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
			dbSet.As<IQueryable<Person>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

			contextMock.Setup(x => x.Set<Person>()).Returns(dbSet.Object);
			var personRepository = new PersonRepository(contextMock.Object);

			var result = personRepository.GetAll();

			contextMock.Verify(x => x.Set<Person>(), Times.Once);
		}
	}
}
