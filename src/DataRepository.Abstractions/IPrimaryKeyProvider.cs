using System;
using System.Linq.Expressions;

namespace DataRepository.Abstractions
{
    public interface IPrimaryKeyProvider<TEntity, TKey>
            where TEntity : class
    {
        Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }
    }
}
