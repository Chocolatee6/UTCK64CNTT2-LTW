using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hqa_231230703_de02.Models;

public partial class HqaCatalog
{
    [Key]
    [Required(ErrorMessage = "Mã sản phẩm là bắt buộc.")]
    [StringLength(10, ErrorMessage = "Mã sản phẩm không được vượt quá 10 ký tự.")]
    [Display(Name = "Mã sản phẩm")]
    public string HqaId { get; set; } = null!;



    [StringLength(50)]
    [Display(Name = "Tên Sản phẩm")]

    public string? HqaCateName { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    [Required(ErrorMessage = "Giá sản phẩm là bắt buộc.")]
    // Lưu ý: Đang sử dụng Range (1000, 5000) theo ví dụ nhỏ. Nếu yêu cầu là 500.000.000, bạn cần thay 5000 bằng 500000000.
    [Range(1000, 500000000, ErrorMessage = "Giá trị phải là số và nằm trong khoảng 1.000 đến 500.000.000.")]
    [Display(Name = "Giá")]

    public decimal? HqaCatePrice { get; set; }

    

    public int? HqaCateQty { get; set; }

    [Display(Name = "Đường dẫn Ảnh")]
    [RegularExpression(@"^.*\.(jpg|png|gif|tiff)$",
            ErrorMessage = "Tên file phải có đuôi .jpg, .png, .gif, hoặc .tiff.")]
    public string? HqaPicture { get; set; }

    
    public bool? HqaCateActive { get; set; }

    [Display(Name = "Thành tiền")]
    [NotMapped]
    public decimal ThanhTien
    {
        get
        {
            return (decimal)(HqaCatePrice * HqaCateQty);
        }
    }


}
