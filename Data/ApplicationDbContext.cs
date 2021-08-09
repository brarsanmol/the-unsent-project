using Microsoft.EntityFrameworkCore;
using The_Unsent_Project.Models;

namespace The_Unsent_Project.Data
{
    /// <summary>
    ///     Our application's database context.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        ///     The table for messages.
        /// </summary>
        public DbSet<Message> Messages { get; init; }
    }
}