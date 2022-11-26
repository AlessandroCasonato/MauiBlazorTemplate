using MauiBlazorTemplate.Core.Models;
using SQLite;

namespace MauiBlazorTemplate.Services
{
    public class SqliteService<T> : ISqliteService<T> where T : BaseSqliteModel, new()
    {
        private SQLiteAsyncConnection _dbConn;
        private readonly string _dbName = "Example.db3";

        public SqliteService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConn == null)
            {
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _dbName);
                _dbConn = new SQLiteAsyncConnection(dbPath);
                await _dbConn.CreateTableAsync<T>();
            }
        }
        public async Task<int> AddStudent(T student)
        {
            return await _dbConn.InsertAsync(student);
        }

        public async Task<int> DeleteStudent(T student)
        {
            return await _dbConn.DeleteAsync(student);
        }

        public async Task<List<T>> GetAllStudent()
        {
            return await _dbConn.Table<T>().ToListAsync();
        }

        public async Task<T> GetStudentById(int id)
        {
            return await _dbConn.Table<T>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> UpdateStudent(T student)
        {
            return await _dbConn.UpdateAsync(student);
        }

    }
}
