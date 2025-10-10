using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaLoai { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TenLoai { get; set; }

        [Column(TypeName = "int")]
        public int TrangThai { get; set; }
        public ICollection<SanPham> sanPhams { get; set; }
    }
}
