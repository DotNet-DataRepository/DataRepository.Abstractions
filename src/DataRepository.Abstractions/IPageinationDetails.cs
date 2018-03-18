namespace DataRepository.Abstractions
{
    public interface IPageinationDetails
    {
        int PageSize { get; }
        int PageNumber { get; }
    }
}
