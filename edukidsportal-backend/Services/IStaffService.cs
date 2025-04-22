using edukidsportal_backend.Entities;

namespace edukidsportal_backend.Services
{
    public interface IStaffService
    {
        Task<IEnumerable<Staff>> GetAllAsync();
    }
}
