using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface ICommandRepository<TEntity> 
        where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity value);
        Task<TEntity> ReplaceAllAsync(TEntity value, Expression<Func<TEntity, bool>> predicate);
        Task DeleteAllAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
