using MauiBlazorTemplate.Core.Models;
using SQLite;

namespace MauiBlazorTemplate.Services;

public class StudentService : IStudentService
{
    private SQLiteAsyncConnection _dbConn;

    public StudentService()
    {
        SetUpDb();
    }

    private async void SetUpDb()
    {
        if (_dbConn == null)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
            _dbConn= new SQLiteAsyncConnection(dbPath);
            await _dbConn.CreateTableAsync<Student>();
        }
    }
    public async Task<int> AddStudent(Student student)
    {
        return await _dbConn.InsertAsync(student);
    }

    public async Task<int> DeleteStudent(Student student)
    {
        return await _dbConn.DeleteAsync(student);
    }

    public async Task<List<Student>> GetAllStudent()
    {
        return await _dbConn.Table<Student>().ToListAsync();
    }

    public async Task<Student> GetStudentById(int id)
    {
        return await _dbConn.Table<Student>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<int> UpdateStudent(Student student)
    {
        return await _dbConn.UpdateAsync(student);
    }
}
