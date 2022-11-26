using MauiBlazorTemplate.Core.Models;

namespace MauiBlazorTemplate.Services
{
    public interface ISqliteService<T>
    {
        Task<List<T>> GetAllStudent();
        Task<T> GetStudentById(int id);
        Task<int> AddStudent(T item);
        Task<int> UpdateStudent(T item);
        Task<int> DeleteStudent(T item);
    }
}