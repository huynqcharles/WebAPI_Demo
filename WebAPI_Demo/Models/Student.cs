using System.ComponentModel.DataAnnotations;

namespace WebAPI_Demo.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Point { get; set; }
    }
}
