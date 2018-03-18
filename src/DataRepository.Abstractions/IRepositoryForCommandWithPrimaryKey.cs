using System.Threading.Tasks;

namespace DataRepository.Abstractions
{
    public interface IRepositoryForCommandWithPrimaryKey<TEntity, TKey> : 
        IPrimaryKeySelector<TEntity, TKey> 
            where TEntity : class
    {
        Task DeleteAsync(TKey key);
        Task<TEntity> UpdateAsync(TEntity value);
    }
}
