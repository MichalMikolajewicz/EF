using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Data.Core
{
	public class AdventureWorksDbContextFactory : IDesignTimeDbContextFactory<AdventureWorks2014Context>
	{
		public AdventureWorks2014Context CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<AdventureWorks2014Context>();
			builder.UseSqlServer("Server=MICHAL\\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;",
				optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(AdventureWorks2014Context).GetTypeInfo().Assembly.GetName().Name));
			return new AdventureWorks2014Context(builder.Options);
		}
	}
}
