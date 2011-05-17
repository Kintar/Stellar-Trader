using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Stellar.Core.Repository
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Remove(T item);
    }
}
