using Microsoft.EntityFrameworkCore;
using WebAPI_Demo.Data;
using WebAPI_Demo.IServices;
using WebAPI_Demo.Models;

namespace WebAPI_Demo.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly MyDbContext _context;
        public StudentServices(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.students.ToListAsync();
        }

        public async Task<Student> PostStudent(Student student)
        {
            await _context.students.AddAsync(student);
            _context.SaveChangesAsync();
            return student;
        }
    }
}
