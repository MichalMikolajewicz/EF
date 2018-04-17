using Data.Persistance.Repositories;
using Data.Models;
using Persistance.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Repositories;

namespace Persistance.Persistence.Repositories
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly AdventureWorks2014Context context;

		public Repository(AdventureWorks2014Context context)
		{
			this.context = context;
		}
		public void Add(TEntity entity)
		{
			context.Set<TEntity>().Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			context.Set<TEntity>().AddRange(entities);
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return context.Set<TEntity>().Where(predicate);
		}

		public TEntity Get(int id)
		{
			return context.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return context.Set<TEntity>().ToList();
		}

		public void Remove(TEntity entity)
		{
			context.Set<TEntity>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			context.Set<TEntity>().RemoveRange(entities);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return context.Set<TEntity>().SingleOrDefault(predicate);
		}
	}
}
