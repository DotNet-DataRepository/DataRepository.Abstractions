using System;
using System.Linq.Expressions;

namespace DataRepository.Abstractions
{
    public interface IPrimaryKeySelector<TEntity, TKey>
            where TEntity : class
    {
        Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }
        TKey GetKey(TEntity entity);
    }
}
