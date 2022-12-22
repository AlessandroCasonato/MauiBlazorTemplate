namespace MauiBlazorTemplate.Services
{
    public interface ISqliteService<T>
    {
        Task<List<T>> GetAllItems();
        Task<T> GetItemById(int id);
        Task<int> AddItem(T item);
        Task<int> UpdateItem(T item);
        Task<int> DeleteItem(T item);
    }
}