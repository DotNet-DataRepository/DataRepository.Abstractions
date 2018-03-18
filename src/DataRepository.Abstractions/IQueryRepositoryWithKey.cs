using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IQueryRepositoryWithKey<TEntity, TKey> : 
        IPrimaryKeyProvider<TEntity, TKey> 
            where TEntity : class
    {
        Task<TEntity> GetAsync(TKey key);
    }
}
