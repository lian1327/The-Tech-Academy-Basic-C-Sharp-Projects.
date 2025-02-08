using Microsoft.EntityFrameworkCore;
using FinalAssignment2.Models;

namespace FinalAssignment2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SampleDB2;Username=postgres;Password=adminadmin");
        }
    }
}
