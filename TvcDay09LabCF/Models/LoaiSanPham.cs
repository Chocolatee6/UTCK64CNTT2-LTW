using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvcDay09LabCF.Models
{
    [Table("TblLoaiSanPham")]
    [Index(nameof(MaLoai),IsUnique = true)]
    public class LoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IDLoaiSanPham { get; set; }

        [Display(Name ="Mã loại sản phẩm")]
        [StringLength(50)]
        public string MaLoai {  get; set; }

        [Display(Name ="Tên loại sản phẩm")]
        [StringLength (50)]
        public string TenLoai { get; set; }

        [Display(Name ="Trạng thái sản phẩm")]
        public bool TrangThai { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
        
    }
}
