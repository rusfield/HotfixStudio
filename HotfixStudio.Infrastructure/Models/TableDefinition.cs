namespace HotfixStudio.Infrastructure.Models
{
    public class TableDefinition
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public List<Column> Columns { get; set; } = new();

        public class Column
        {
            public string Name { get; set; }
            public Type Type { get; set; }
        }
    }
}
