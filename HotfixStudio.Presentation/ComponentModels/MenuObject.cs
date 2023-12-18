using Microsoft.AspNetCore.Components;

namespace HotfixStudio.Presentation.ComponentModels
{
    public class MenuObject
    {
        public string Header { get; set; }
        public string IconName { get; set; }    
        public List<Section> Sections { get; set; } = new();

        public void AddSection(Dictionary<string, EventCallback> items)
        {
            Sections.Add(new()
            {
                Items = items
            });
        }

        public int GetTotalItems()
        {
            return Sections.Sum(section => section.Items.Count);
        }

        public class Section
        {
            public Dictionary<string, EventCallback> Items { get; set; }
        }
    }
}
