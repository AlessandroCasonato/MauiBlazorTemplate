using SQLite;

namespace MauiBlazorTemplate.Core.Models
{
    public class BaseSqliteModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
