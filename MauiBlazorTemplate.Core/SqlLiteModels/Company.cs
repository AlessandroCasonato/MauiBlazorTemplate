using MauiBlazorTemplate.Core.BaseModels;

namespace MauiBlazorTemplate.Core.SqlLiteModels
{
    public class Company : BaseSqliteModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsConsulting { get; set; }
        public string? Dimension { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public bool? Favorite { get; set; }

    }
}
