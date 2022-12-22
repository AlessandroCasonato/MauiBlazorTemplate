using MauiBlazorTemplate.Core.BaseModels;

namespace MauiBlazorTemplate.Core.SqlLiteModels
{
    public class Contact : BaseSqliteModel
    {
        public Company Company { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime LastContactDateTime { get; set; }

    }
}
