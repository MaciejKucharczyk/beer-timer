using Microsoft.EntityFrameworkCore;

namespace beer_timer.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ranking>(entity =>
            {
                entity.ToTable("Ranking");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Technique).HasMaxLength(256);

                entity.Property(e => e.UserNameId)
                    .HasMaxLength(450)
                    .HasColumnName("UserName_Id");
            });
        }

        public DbSet<Ranking> Rankings { get;set; }
    }
}
