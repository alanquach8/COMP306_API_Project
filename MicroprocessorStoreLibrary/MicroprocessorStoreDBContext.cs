using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroprocessorStoreLibrary
{
    public partial class MicroprocessorStoreDBContext : DbContext
    {
        public MicroprocessorStoreDBContext()
        {
        }

        public MicroprocessorStoreDBContext(DbContextOptions<MicroprocessorStoreDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Microprocessor> Microprocessor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server = localhost; port = 3306; database = COMP306ProjectLocalDB; user = root; password = password");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar")
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("varchar")
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Microprocessor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar")
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("varchar")
                    .HasMaxLength(200);
            });
        }
    }
}
