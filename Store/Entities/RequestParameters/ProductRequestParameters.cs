namespace Entities.RequestParameters
{
    public class ProductRequestParameters : RequestParameters
    {
        public int? CategoryId { get; set; }
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = int.MaxValue;
        public bool IsValidPrice => MaxPrice > MinPrice;
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public bool IsNull => CategoryId == null && PageNumber == 1 && PageSize == 6 ;
        public ProductRequestParameters() : this(1,6)
        {
            
        }
        public ProductRequestParameters(int pageNumber=1, int pageSize=6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

    }
}