using WebAPI_Demo.Models;

namespace WebAPI_Demo.IServices
{
    public interface IStudentServices
    {
        public Task<IEnumerable<Student>> GetStudents();
        public Task<Student> PostStudent(Student student);
    }
}
