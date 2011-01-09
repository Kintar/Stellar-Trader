using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Repository
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Add(T item);
        void Remove(T item);
    }
}
