namespace HotfixStudio.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsIgnoreCase(this string str, string? contains)
        {
            return contains == null ? true : str.Contains(contains, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
