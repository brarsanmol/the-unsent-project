using Microsoft.EntityFrameworkCore;
using The_Unsent_Project.Models;

namespace The_Unsent_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Message> Messages { get; init; }
    }
}