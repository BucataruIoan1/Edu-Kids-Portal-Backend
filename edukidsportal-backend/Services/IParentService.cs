using edukidsportal_backend.Entities;

namespace edukidsportal_backend.Services
{
    public interface IParentService
    {
        Task<IEnumerable<Parent>> GetAllAsync();
    }
}
