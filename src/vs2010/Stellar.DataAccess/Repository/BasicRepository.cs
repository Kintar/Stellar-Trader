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

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return items.AsQueryable().Where(predicate);
        }

        public IQueryable<T> All()
        {
            return items.AsQueryable();
        }

        public void Add(T item)
        {
            if (!items.Contains(item)) items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void Dispose()
        {
            // I /think/ this will invalidate any IQueryables that are still floating around out there
            // TODO: validate the above assumption
            items = null;
        }
    }
}
