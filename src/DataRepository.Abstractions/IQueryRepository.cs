using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IQueryRepository<TEntity> 
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(int maxResults);
        Task<IEnumerable<TEntity>> GetAllAsync(IPaginationDetails pageInfo);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, int maxResults);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, IPaginationDetails pageInfo);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        #region Aggregates

        Task<long> CountAsync();
        Task<long> CountAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }
}
