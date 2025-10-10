using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public byte Status { get; set; }

        [StringLength(1000, ErrorMessage = "Mô tả không được vượt quá 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Danh mục không được để trống")]
        public int CatogoryId { get; set; }
        public Catogory Catogory { get; set; }
    }
}