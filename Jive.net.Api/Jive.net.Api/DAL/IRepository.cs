﻿using System.Linq;

namespace Jive.net.DAL
{
	public interface IRepository<T>
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		IQueryable<T> GetAll();
		T GetById(long id);
	}
}
