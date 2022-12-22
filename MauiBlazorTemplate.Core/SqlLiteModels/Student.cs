using MauiBlazorTemplate.Core.BaseModels;
using SQLite;

namespace MauiBlazorTemplate.Core.SqlLiteModels;

[Table("Student")]
public class Student : BaseSqliteModel
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
}
