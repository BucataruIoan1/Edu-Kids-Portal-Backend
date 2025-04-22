using edukidsportal_backend.Entities;

namespace edukidsportal_backend.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
    }
}
