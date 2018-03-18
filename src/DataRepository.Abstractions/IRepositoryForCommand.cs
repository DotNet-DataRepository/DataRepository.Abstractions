using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IRepositoryForCommand<TEntity> 
        where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity value);
        Task<TEntity> ReplaceAsync(TEntity value, Expression<Func<TEntity, bool>> predicate);
        Task Delete(Expression<Func<TEntity, bool>> predicate);
    }
}
