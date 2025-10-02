using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
namespace NetCoreMVCLAB5.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name = "Họ và tên"),
            Required(ErrorMessage = "Vui lòng nhập họ"),
            MinLength(6, ErrorMessage = "Họ và tên phải có ít nhất 6 ký tự"),
            MaxLength(50, ErrorMessage = "Họ và tên không được vượt quá 50 ký tự")
            ]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Email"),
            Required(ErrorMessage = "Vui lòng nhập email"),
            EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email"),
            DataType(DataType.EmailAddress)
        ]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại"),
            DataType(DataType.PhoneNumber),
            Remote(action:"VerifyPhone",controller:"Account"),
            Phone(ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại"),
            Required(ErrorMessage = "Vui lòng nhập số điện thoại")
        ]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ"),
            Required(ErrorMessage = "Vui lòng nhập địa chỉ"),
            MinLength(6, ErrorMessage = "Địa chỉ phải có ít nhất 6 ký tự"),
            MaxLength(100, ErrorMessage = "Địa chỉ không được vượt quá 100 ký tự")
        ]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")
        ]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh"),
            DataType(DataType.Date),
            Required(ErrorMessage = "Vui lòng nhập ngày sinh")
        ]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính"),
        ]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu"),
            Required(ErrorMessage = "Vui lòng nhập mật khẩu"),
            DataType(DataType.Password)
        ]
        public string Password { get; set; }

        [Display(Name = "Facebook"),
            DataType(DataType.Url),
            RegularExpression(@"^(https?:\/\/)?(www\.)?facebook\.com\/[a-zA-Z0-9(\.\?)?]", ErrorMessage = "Vui lòng nhập đúng định dạng URL Facebook")
        ]
        public string Facebook { get; set; }
    }
}
