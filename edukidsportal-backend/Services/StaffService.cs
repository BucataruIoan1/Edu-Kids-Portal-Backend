using edukidsportal_backend.Entities;
using edukidsportal_backend.Data;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace edukidsportal_backend.Services
{
    public class StaffService : IStaffService
    {
        private readonly EdukidsDbContext _context;

        public StaffService(EdukidsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Staff>> GetAllAsync()
        {
            using var connection = _context.CreateConnection();
            var staff = await connection.QueryAsync<Staff>("StaffGet", commandType: CommandType.StoredProcedure);
            return staff;
        }
    }
}
