using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaHoaDon { get; set; }

        [Column(TypeName = "int")]
        public int MaKhachHang { get; set; }
        public KhachHang KhachHang { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string HoTenKhachHang { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string DienThoai { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DiaChi { get; set; }
        [Column(TypeName = "float")]
        public float TongTien { get; set; }

        [Column(TypeName = "int")]
        public int TrangThai { get; set; }
        public ICollection<CTHoaDon> cTHoaDons { get; set; } = new List<CTHoaDon>();
    }
}
