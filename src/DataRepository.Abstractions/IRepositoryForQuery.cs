using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IRepositoryForQuery<TEntity> 
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(IPageinationDetails pageInfo);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, IPageinationDetails pageInfo);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
