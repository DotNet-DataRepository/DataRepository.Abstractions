namespace DataRepository.Abstractions
{
    public interface IRepositoryWithPrimaryKey<TEntity, TKey> : 
        IRepository<TEntity>, 
        IRepositoryForQueryWithPrimaryKey<TEntity, TKey>, 
        IRepositoryForCommandWithPrimaryKey<TEntity, TKey> 
            where TEntity : class
    {
    }
}
