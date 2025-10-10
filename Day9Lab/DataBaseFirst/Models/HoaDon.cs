using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public string MaHoaDon { get; set; } = null!;

    public int MaKhachHang { get; set; }

    public DateTime NgayLap { get; set; }

    public string HoTenKhachHang { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public double TongTien { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<CthoaDon> CthoaDons { get; set; } = new List<CthoaDon>();

    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
}
