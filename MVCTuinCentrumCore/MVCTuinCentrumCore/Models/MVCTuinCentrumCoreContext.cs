using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCTuinCentrumCore.Models
{
    public partial class MVCTuinCentrumCoreContext : DbContext
    {
        //public MVCTuinCentrumCoreContext()
        //{
        //}

        public MVCTuinCentrumCoreContext(DbContextOptions<MVCTuinCentrumCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Leverancier> Leveranciers { get; set; }
        public virtual DbSet<Plant> Planten { get; set; }
        public virtual DbSet<Soort> Soorten { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MVCTuinCentrumCore;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leverancier>(entity =>
            {
                entity.HasKey(e => e.LevNr)
                    .HasName("Leveranciers$PrimaryKey");

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PostNr)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Woonplaats)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.HasKey(e => e.PlantNr)
                    .HasName("Planten$PrimaryKey");

                entity.Property(e => e.Kleur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.VerkoopPrijs).HasColumnType("money");

                entity.HasOne(d => d.LevnrNavigation)
                    .WithMany(p => p.Planten)
                    .HasForeignKey(d => d.Levnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Planten$LeveranciersPlanten");

                entity.HasOne(d => d.SoortNrNavigation)
                    .WithMany(p => p.Planten)
                    .HasForeignKey(d => d.SoortNr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Planten$SoortenPlanten");
            });

            modelBuilder.Entity<Soort>(entity =>
            {
                entity.HasKey(e => e.SoortNr)
                    .HasName("Soorten$PrimaryKey");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Soort");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
