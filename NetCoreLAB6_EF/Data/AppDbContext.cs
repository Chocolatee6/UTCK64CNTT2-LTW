using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF.Models;
namespace NetCoreLAB6_EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catogory> Catogories { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    // Cấu hình quan hệ một-nhiều giữa Catogory và Product
        //    modelBuilder.Entity<Catogory>()
        //        .HasMany(c => c.Products)
        //        .WithOne(p => p.Catogory)
        //        .HasForeignKey(p => p.CatogoryId)
        //        .OnDelete(DeleteBehavior.Cascade); // Xóa sản phẩm khi danh mục bị xóa
        //}
    }
}
