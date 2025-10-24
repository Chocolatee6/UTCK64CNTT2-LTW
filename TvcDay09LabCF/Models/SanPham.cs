using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TvcDay09LabCF.Models
{
    [Table("tblSanPham")]
    
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IDSanPham { get; set; }

        [Display(Name ="Mã Sản Phẩm")]
        [StringLength(50)]
        public string MaSanPham { get; set; }

        [Display(Name ="Tên Sản Phẩm")]
        public string TenSanPham { get; set; }


        [Display(Name ="Hình Ảnh")]
        public string HinhAnh { get; set; }


        [Display(Name ="Số Lượng")]
        public int SoLuong { get; set; }

        [Display(Name ="Đơn Giá")]
        public decimal DonGia { get; set; }

        [Display(Name ="Loại Sản Phẩm")]
        public long LoaiSanPhamID { get; set; }

        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
