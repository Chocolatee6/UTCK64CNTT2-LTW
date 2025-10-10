using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string MaKhachHang { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HoTen { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string MatKhau { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string DienThoai { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string DiaChi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayDangKi { get; set; }

        [Column(TypeName = "int")]

        public int TrangThai { get; set; }
        public ICollection<HoaDon> hoaDons { get; set; } = new List<HoaDon>();
    }
}
