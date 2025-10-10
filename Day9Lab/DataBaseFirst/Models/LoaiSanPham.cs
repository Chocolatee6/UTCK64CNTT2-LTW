using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class LoaiSanPham
{
    public int Id { get; set; }

    public string MaLoai { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public int TrangThai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
