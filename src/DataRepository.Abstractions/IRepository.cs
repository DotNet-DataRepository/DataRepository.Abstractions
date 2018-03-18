namespace DataRepository.Abstractions
{
    public interface IRepository<TEntity> : 
        IQueryRepository<TEntity>, 
        ICommandRepository<TEntity> 
            where TEntity : class
    {
    }
}
