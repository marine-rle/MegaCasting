using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MegaCasting.Class;

public partial class DbMegacastingContext : DbContext
{
    // Constructeur par défaut du contexte de base de données
    public DbMegacastingContext()
    {
    }

    public DbMegacastingContext(DbContextOptions<DbMegacastingContext> options)
        : base(options)
    {
    }

    // Déclaration des DbSet pour les entités User, Partner et Announce
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Partner> Partners { get; set; }
    public virtual DbSet<Announce> Announces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=db_megacasting;user=root;password=;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuration de l'entité User
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Firstname).HasMaxLength(75);
            entity.Property(e => e.Lastname).HasMaxLength(75);
            entity.Property(e => e.Password).HasMaxLength(100);
        });

        // Configuration de l'entité Partner
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("partners");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Label).HasMaxLength(100);
            entity.Property(e => e.SIRET).HasMaxLength(14);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.DateTime).HasColumnType("datetime");


        });

        // Configuration de l'entité Announce
        modelBuilder.Entity<Announce>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("announces");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Content).HasMaxLength(100);
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
