using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CTHoaDon> CTHoaDons { get; set; }
        public DbSet<QuanTri> QuanTris { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure relationships and constraints if needed
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhachHang)
                .WithMany(k => k.hoaDons)
                .HasForeignKey(h => h.MaKhachHang);
            modelBuilder.Entity<CTHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(h => h.cTHoaDons)
                .HasForeignKey(ct => ct.HoaDonID);
            // Add other configurations as necessary
        }
        public DbSet<CodeFirst.Models.SanPham> SanPham { get; set; } = default!;
    }
    
    }

