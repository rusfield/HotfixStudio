using HotfixStudio.Infrastructure.Extensions;

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

        public OptionResult<T> GenerateNewResults(OptionSearch<T> search)
        {
            var newResult = new OptionResult<T>();
            if(search.PageSize == 1 && search.SelectedValues.Count == 1)
            {
                string singleValue = $"Unknown ({search.SelectedValues.First()})";
                if (Options.TryGetValue(search.SelectedValues.First(), out var val))
                    singleValue = val;
                newResult.Options.Add(search.SelectedValues.First(), singleValue);
            }
            else
            {
                foreach (var option in Options)
                {
                    if (option.Value.ContainsIgnoreCase(search.Search))
                        newResult.Options.Add(option.Key, option.Value);
                }
            }


            newResult.PageIndex = 0;
            newResult.PageSize = newResult.Options.Count;
            newResult.TotalRows = newResult.Options.Count;
            return newResult;
        }
    }
}
