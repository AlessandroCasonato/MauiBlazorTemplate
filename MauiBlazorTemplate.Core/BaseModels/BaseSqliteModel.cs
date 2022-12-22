using SQLite;

namespace MauiBlazorTemplate.Core.BaseModels
{
    public class BaseSqliteModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
