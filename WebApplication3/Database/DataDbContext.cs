using Microsoft.EntityFrameworkCore;
using WebApplication3.model;

namespace WebApplication3.Database
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<employee> Employees { get; set; }

        public DbSet<position> Positions { get; set; }


    }
}
