using Microsoft.EntityFrameworkCore;
using WebAPI_Demo.Models;

namespace WebAPI_Demo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
