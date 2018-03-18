namespace DataRepository.Abstractions
{
    public interface IPaginationDetails
    {
        int PageSize { get; }
        int PageNumber { get; }
    }
}
