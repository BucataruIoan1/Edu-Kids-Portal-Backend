using edukidsportal_backend.Entities;
using edukidsportal_backend.Data;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace edukidsportal_backend.Services
{
    public class ParentService : IParentService
    {
        private readonly EdukidsDbContext _context;

        public ParentService(EdukidsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Parent>> GetAllAsync()
        {
            using var connection = _context.CreateConnection();
            var parents = await connection.QueryAsync<Parent>("ParentsGet", commandType: CommandType.StoredProcedure);
            return parents;
        }
    }
}
