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
		[Fact]
		public void Should_Run_GetAll()
		{
			//Arrange
			var optionsBuilder = Setup();
			var context = new AdventureWorks2014Context(optionsBuilder.Options);
			var personRepository = new PersonRepository(context);

			//Act
			var result = personRepository.GetAll();

			//Assert
			Assert.NotNull(result);
		}

		private DbContextOptionsBuilder<AdventureWorks2014Context> Setup()
		{
			var optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2014Context>();
			var connection = @"Server=MICHAL\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;";
			optionsBuilder.UseSqlServer(connection);
			return optionsBuilder;
		}
	}
}
