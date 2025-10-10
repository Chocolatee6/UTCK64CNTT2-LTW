using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class QuanTri
{
    public int Id { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int TrangThai { get; set; }
}
