using Bigon2.Models.Entites;
using Bigon2.Models.Persistences.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Bigon2.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Color>(new ColorEntityConfigurations());
        }
        public DbSet<Color> Colors { get; set; }

    }
}
