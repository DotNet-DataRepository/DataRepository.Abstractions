namespace DataRepository.Abstractions
{
    public interface IRepository<TEntity> : 
        IRepositoryForQuery<TEntity>, 
        IRepositoryForCommand<TEntity> 
            where TEntity : class
    {
    }
}
