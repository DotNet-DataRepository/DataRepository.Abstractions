namespace DataRepository.Abstractions
{
    public class PaginationDetails
    {
        #region Constructor

        public PaginationDetails(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }

        #endregion
        
        #region Properties

        public int PageSize { get; }
        public int PageNumber { get; }

        #endregion
        
        #region Builder Methods

        public static PaginationDetails New(int pageSize, int pageNumber)
        {
            return new PaginationDetails(pageSize, pageNumber);
        }

        public static PaginationDetails New(int pageSize)
        {
            return new PaginationDetails(pageSize, 0);
        }

        #endregion
    }
}
