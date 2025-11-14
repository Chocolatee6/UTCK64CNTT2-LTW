using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Lab1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength =4, ErrorMessage ="Tên phải có độ dài từ 4 ký tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Email là bắt buộc")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@(gmail\.com|googlemail\.com)$", ErrorMessage = "Email phải là địa chỉ Gmail hợp lệ (ví dụ: tenban@gmail.com)")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có độ dài từ 8 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt")]
        public string? Password { get; set; }

        [Required]
        public Branch? Branch { get; set; }

        [Required]
        public Gender? Gender { get; set; }

        public bool IsRegular { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }

        [Range(typeof(DateTime),"1/1/1963","12/31/2005", ErrorMessage ="Ngày sinh không hợp lệ")]
        [DataType(DataType.Date)]
        public DateTime DateOfBorth { get; set; }

        [Required(ErrorMessage = "Điểm là trường bắt buộc.")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ {1} đến {2}.")]
        public double Score { get; set; }
    }
}
