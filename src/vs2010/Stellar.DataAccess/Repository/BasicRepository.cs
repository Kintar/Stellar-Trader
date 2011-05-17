using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Stellar.Core.Repository
{
    public class BasicRepository<T> : IRepository<T>
    {
        private ICollection<T> items;

        public BasicRepository(ICollection<T> collection)
        {
            items = collection;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return items.AsQueryable().Where(predicate);
        }

        public IEnumerable<T> All()
        {
            ICollection<T> threadSafeIterable = new List<T>(items);
            return threadSafeIterable;
        }

        public void Add(T item)
        {
            if (!items.Contains(item)) items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Unimplemented : There's no valid use for IDisposable in this implementation
        /// </summary>
        public void Dispose()
        {
            // GNDN
        }
    }
}
