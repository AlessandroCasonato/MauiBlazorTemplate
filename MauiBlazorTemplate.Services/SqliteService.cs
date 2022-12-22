using MauiBlazorTemplate.Core.BaseModels;
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
        public async Task<int> AddItem(T item)
        {
            return await _dbConn.InsertAsync(item);
        }

        public async Task<int> DeleteItem(T item)
        {
            return await _dbConn.DeleteAsync(item);
        }

        public async Task<List<T>> GetAllItems()
        {
            return await _dbConn.Table<T>().ToListAsync();
        }

        public async Task<T> GetItemById(int id)
        {
            return await _dbConn.Table<T>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> UpdateItem(T item)
        {
            return await _dbConn.UpdateAsync(item);
        }

    }
}
