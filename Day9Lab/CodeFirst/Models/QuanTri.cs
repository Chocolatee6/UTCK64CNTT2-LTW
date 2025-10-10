using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    [Table("QuanTri")]
    public class QuanTri
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string TenDangNhap { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string MatKhau { get; set; }

        [Column(TypeName ="int")]
        public int TrangThai { get; set; }
    }
}
