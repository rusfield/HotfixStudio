namespace HotfixStudio.Infrastructure.PresentationData
{
    public class OptionSearch<T>
    {
        public List<T> SelectedValues { get; set; } = new();
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string? Search { get; set; }
        public CancellationToken CancellationToken { get; set; }

        public OptionSearch(List<T> selectedValues, int pageSize, CancellationToken cancellationToken) 
        { 
            SelectedValues = selectedValues;
            PageSize = pageSize;
            CancellationToken = cancellationToken;
        }

        public OptionSearch(List<T> selectedValues, int pageSize, int pageIndex, string search, CancellationToken cancellationToken)
            : this(selectedValues, pageSize, cancellationToken)
        {
            PageIndex = pageIndex;
            Search = search;
        }
    }
}
