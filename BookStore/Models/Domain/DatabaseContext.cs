using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace BookStore.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)

        {

        }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Publisher>Publishers { get; set; }
        public DbSet<Book>Books { get; set; }

    } 
}
