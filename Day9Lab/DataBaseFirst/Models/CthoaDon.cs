using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class CthoaDon
{
    public int Id { get; set; }

    public int HoaDonId { get; set; }

    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public double ThanhTien { get; set; }

    public int TrangThai { get; set; }

    public virtual HoaDon HoaDon { get; set; } = null!;

    public virtual SanPham SanPham { get; set; } = null!;
}
