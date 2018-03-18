namespace DataRepository.Abstractions
{
    public interface IRepositoryWithKey<TEntity, TKey> : 
        IRepository<TEntity>, 
        IQueryRepositoryWithKey<TEntity, TKey>, 
        ICommandRepositoryWithKey<TEntity, TKey> 
            where TEntity : class
    {
    }
}
