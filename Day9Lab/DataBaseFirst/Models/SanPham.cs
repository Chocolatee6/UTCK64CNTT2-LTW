using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class SanPham
{
    public int Id { get; set; }

    public string MaSanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public string HinhAnh { get; set; } = null!;

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public string MaLoai { get; set; } = null!;

    public int TrangThai { get; set; }

    public int LoaiSanPhamId { get; set; }

    public virtual ICollection<CthoaDon> CthoaDons { get; set; } = new List<CthoaDon>();

    public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
}
