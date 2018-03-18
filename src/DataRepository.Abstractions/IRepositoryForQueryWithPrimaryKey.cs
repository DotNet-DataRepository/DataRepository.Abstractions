using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IRepositoryForQueryWithPrimaryKey<TEntity, TKey> : 
        IPrimaryKeySelector<TEntity, TKey> 
            where TEntity : class
    {
        Task<TEntity> GetAsync(TKey key);
    }
}
