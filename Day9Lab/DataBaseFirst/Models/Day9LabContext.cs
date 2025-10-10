using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Models;

public partial class Day9LabContext : DbContext
{
    public Day9LabContext()
    {
    }

    public Day9LabContext(DbContextOptions<Day9LabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CthoaDon> CthoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=YING;Database=Day9Lab;User Id=sa;Password=12345;TrustServerCertificate=True;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CthoaDon>(entity =>
        {
            entity.ToTable("CTHoaDon");

            entity.HasIndex(e => e.HoaDonId, "IX_CTHoaDon_HoaDonID");

            entity.HasIndex(e => e.SanPhamId, "IX_CTHoaDon_SanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.CthoaDons).HasForeignKey(d => d.HoaDonId);

            entity.HasOne(d => d.SanPham).WithMany(p => p.CthoaDons).HasForeignKey(d => d.SanPhamId);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.ToTable("HoaDon");

            entity.HasIndex(e => e.MaKhachHang, "IX_HoaDon_MaKhachHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(50);
            entity.Property(e => e.MaHoaDon).HasMaxLength(10);
            entity.Property(e => e.NgayLap).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons).HasForeignKey(d => d.MaKhachHang);
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.ToTable("KhachHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaKhachHang).HasMaxLength(10);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.NgayDangKi).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoai).HasMaxLength(10);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<QuanTri>(entity =>
        {
            entity.ToTable("QuanTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.TenDangNhap).HasMaxLength(10);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.ToTable("SanPham");

            entity.HasIndex(e => e.LoaiSanPhamId, "IX_SanPham_LoaiSanPhamID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HinhAnh).HasMaxLength(50);
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaLoai).HasMaxLength(10);
            entity.Property(e => e.MaSanPham).HasMaxLength(10);
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.LoaiSanPham).WithMany(p => p.SanPhams).HasForeignKey(d => d.LoaiSanPhamId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
