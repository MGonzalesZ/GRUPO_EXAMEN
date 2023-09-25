using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace emergentesAPI.DAL.DataContext;

public partial class DbA9f478TecemergContext : DbContext
{
    public DbA9f478TecemergContext()
    {
    }

    public DbA9f478TecemergContext(DbContextOptions<DbA9f478TecemergContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SQL5103.site4now.net; Database=db_a9f478_tecemerg; User Id=db_a9f478_tecemerg_admin; Password=tecEmerg23; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Telefono__3214EC27F967C2C6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.NumeroTelefonico).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
