    using BE_U3_W3_D1.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace BE_U3_W3_D1.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context;
        
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAsNoTracking() //AsNoTracking si usa per migliorare le performance delle query di sola lettura, non si possono fare modifiche
        {
            return await _context.Students.AsNoTracking().ToListAsync();
        }

        public async Task<Student> GetByIdAsNoTracking(Guid Id)
        {
            return await _context.Students.AsNoTracking().FirstOrDefaultAsync(s => s.Id == Id);
        }
    }
}
