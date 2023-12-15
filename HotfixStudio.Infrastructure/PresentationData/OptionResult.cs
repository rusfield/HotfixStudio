namespace HotfixStudio.Infrastructure.PresentationData
{
    public class OptionResult<T>
    {
        public Dictionary<T, string> Options { get; set; } = new();
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRows { get; set; }
        public int TotalPages
        {
            get
            {
                return PageSize > 0 ? (int)TotalRows / PageSize : 0;
            }
        }
    }
}
