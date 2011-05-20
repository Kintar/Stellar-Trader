using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Stellar.Core.Repository
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Remove(T item);
    }
}
