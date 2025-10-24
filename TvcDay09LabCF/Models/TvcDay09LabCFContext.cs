using Microsoft.EntityFrameworkCore;
namespace TvcDay09LabCF.Models
{
    public class TvcDay09LabCFContext : DbContext
    {
        public TvcDay09LabCFContext(DbContextOptions<TvcDay09LabCFContext> options) : base(options) { }

        public DbSet<LoaiSanPham> tvcLoaiSanPhams { get; set; }
        public DbSet<SanPham> tvcSanPhams { get;set; }
    }
}
