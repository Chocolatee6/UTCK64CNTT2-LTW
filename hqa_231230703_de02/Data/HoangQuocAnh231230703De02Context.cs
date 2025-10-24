using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using hqa_231230703_de02.Models;

namespace HoangQuocAnh231230703de02ConText;

public partial class HoangQuocAnh231230703De02Context : DbContext
{
    public HoangQuocAnh231230703De02Context()
    {
    }

    public HoangQuocAnh231230703De02Context(DbContextOptions<HoangQuocAnh231230703De02Context> options)
        : base(options)
    {
    }

    public virtual DbSet<HqaCatalog> HqaCatalogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=YING;Database=HoangQuocAnh_231230703_de02;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HqaCatalog>(entity =>
        {
            entity.HasKey(e => e.HqaId).HasName("PK__HqaCatal__F585C2ECB571674F");

            entity.ToTable("HqaCatalog");

            entity.Property(e => e.HqaId)
                .HasMaxLength(10)
                .HasColumnName("hqaId");
            entity.Property(e => e.HqaCateActive).HasColumnName("hqaCateActive");
            entity.Property(e => e.HqaCateName)
                .HasMaxLength(50)
                .HasColumnName("hqaCateName");
            entity.Property(e => e.HqaCatePrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("hqaCatePrice");
            entity.Property(e => e.HqaCateQty).HasColumnName("hqaCateQty");
            entity.Property(e => e.HqaPicture).HasColumnName("hqaPicture");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
