﻿using OnlineDars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDars.DataAccess.Interfaces
{
	public interface IGenericRepository<T>: IRepository<T> where T : BaseEntity
	{
		public IQueryable<T> GetAll();
		public IQueryable<T> Where(Expression<Func<T, bool>> expression);
	}
}
