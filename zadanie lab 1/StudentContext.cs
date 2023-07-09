using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using zadanie_lab_1.Entities;
using zadanie_lab_1.Models;

namespace zadanie_lab_1
{
    public class StudentDbContext : IdentityDbContext<UserEntity,UserRole, int>

    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
}
