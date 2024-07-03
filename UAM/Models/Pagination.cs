namespace UAM.Models
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int TotalRecord { get; set; }
        public int PageCount => (TotalRecord % PageSize ==0 ? 0 : 1)+(TotalRecord / PageSize);
        public int PageSize { get; set; }

    }
}
