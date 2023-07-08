using Microsoft.EntityFrameworkCore;
using zadanie_lab_1.Entities;

namespace zadanie_lab_1
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
}
