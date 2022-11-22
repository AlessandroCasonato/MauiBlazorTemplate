using MauiBlazorTemplate.Core.Models;

namespace MauiBlazorTemplate.Services;

public interface IStudentService
{
    Task<List<Student>> GetAllStudent();
    Task<Student> GetStudentById(int id);
    Task<int> AddStudent(Student student);
    Task<int> UpdateStudent(Student student);
    Task<int> DeleteStudent(Student student);
}
