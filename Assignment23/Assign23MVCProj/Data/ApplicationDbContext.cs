using Microsoft.EntityFrameworkCore;
using Assign23MVCProj.Models;

namespace Assign23MVCProj.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
