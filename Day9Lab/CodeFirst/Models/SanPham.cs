using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string MaSanPham { get; set;}

        [Column(TypeName = "nvarchar(100)")]
        public string TenSanPham { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string HinhAnh { get; set; }
        
        [Column(TypeName = "int")]
        public int SoLuong { get; set; }

        [Column(TypeName = "float")]
        public float DonGia { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string MaLoai { get; set; }

        [Column(TypeName = "int")]

        public int TrangThai { get; set; }

        public LoaiSanPham LoaiSanPham { get; set; }
        public ICollection<CTHoaDon> cTHoaDons { get; set; } = new List<CTHoaDon>();
    }
}
