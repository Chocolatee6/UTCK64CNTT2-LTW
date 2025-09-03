namespace BTT1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Branch? Branch { get; set; }
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; } // true: chinh quy false; khong chinh quy
        public string? Adress { get; set; }
        public DateTime DateOfBorth { get; set; } // ngay sinh
    }
}
