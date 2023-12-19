
namespace HotfixStudio.Infrastructure.Models
{
    public class DbTemplate
    {
        public string Schema { get; set; }
        public string Table { get; set; }
        public List<Column> Columns { get; set; } = new();

        public DbTemplate(string table, string schema) 
        {
            Table = table;
            Schema = schema;
        }

        public class Column
        {
            public string Name { get; set; }
            public Type Type { get; set; }
            public object? OverrideValue { get; set; }
            public string? Description { get; set; }
            public BasicOptions? SingleSelect { get; set; }
            public BasicOptions? MultiSelect { get; set; }

            public Column(string name, Type type)
            {
                Name = name;
                Type = type;
            }
        }

        public class BasicOptions
        {
            public string? Schema { get; set; }
            public string Table { get; set; }
            public string Value { get; set; }
            public string Display { get; set; }
        }
    }
}
