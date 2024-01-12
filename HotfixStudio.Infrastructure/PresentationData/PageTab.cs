namespace HotfixStudio.Infrastructure.PresentationData
{
    public class PageTab
    {
        public string Label { get; set; }
        public string Base64IconString { get; set; }
        public Type PageComponent { get; set; }
        public bool IsClosable { get; set; } = true;
    }
}
