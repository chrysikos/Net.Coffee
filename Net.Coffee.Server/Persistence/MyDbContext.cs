using Microsoft.EntityFrameworkCore;
using Net.Coffee.Domain;

namespace Net.Coffee.Server.Persistence
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.ID).HasDefaultValueSql("NEWSEQUENTIALID()");
            modelBuilder.Entity<User>()
                .Property(x => x.DiscountPercentage)
                .HasColumnType("decimal(19, 4)")
                .HasDefaultValue(0.00m);
            modelBuilder.Entity<User>().OwnsOne(x => x.Credentials);
            modelBuilder.Entity<User>().OwnsOne(x => x.Contact).OwnsOne(x => x.Address);
        }
        public DbSet<User> Users { get; set; }
    }
}
