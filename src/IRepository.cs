using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Select();
        T Select<TKey>(TKey key);
        IEnumerable<T> Select(Func<T, bool> expr);
        void Insert(T entity);

        void BulkInsert(IEnumerable<T> entities, bool rollback);
        void Update(T entity);

        void Delete<TKey>(TKey id);
    }
}
