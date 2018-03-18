using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface ICommandRepositoryWithKey<TEntity, TKey> : 
        IPrimaryKeyProvider<TEntity, TKey> 
            where TEntity : class
    {
        Task DeleteAsync(TKey key);
        Task<TEntity> ReplaceAsync(TEntity value);
    }
}
