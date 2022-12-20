using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace beer_timer.Models
{
    public partial class BeerContext : DbContext
    {
        public BeerContext()
        {
        }

        public BeerContext(DbContextOptions<BeerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ranking> Rankings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
