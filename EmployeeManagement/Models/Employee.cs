using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        
        public decimal Salary { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
