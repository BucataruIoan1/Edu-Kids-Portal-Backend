using edukidsportal_backend.Entities;
using edukidsportal_backend.Data;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace edukidsportal_backend.Services
{
    public class StudentService : IStudentService
    {
        private readonly EdukidsDbContext _context;

        public StudentService(EdukidsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            using var connection = _context.CreateConnection();
            var students = await connection.QueryAsync<Student>("StudentsGet", commandType: CommandType.StoredProcedure);
            return students;
        }
    }
}
