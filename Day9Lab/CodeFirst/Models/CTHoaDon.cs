using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    [Table("CTHoaDon")]
    public class CTHoaDon
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "int")]
        public int HoaDonID { get; set; }
        public HoaDon HoaDon { get; set; }
        [Column(TypeName = "int")]
        public int SanPhamID { get; set; }
        public SanPham SanPham { get; set; }
        [Column(TypeName = "int")]
        public int SoLuong { get; set; }
        [Column(TypeName = "float")]
        public float DonGia { get; set; }

        [Column(TypeName ="float")]
        public float ThanhTien { get; set; }

        [Column(TypeName = "int")]
        public int TrangThai { get; set; }

       
    }
}
