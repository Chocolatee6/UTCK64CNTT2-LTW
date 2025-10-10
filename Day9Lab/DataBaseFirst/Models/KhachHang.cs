using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    public string MaKhachHang { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public DateTime NgayDangKi { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
