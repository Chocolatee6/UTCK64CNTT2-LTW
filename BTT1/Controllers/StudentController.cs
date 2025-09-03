using BTT1.Models;
using Microsoft.AspNetCore.Mvc;
using BTT1.Models;
namespace BTT1.Controllers
{
    public class StudentController : Controller
    {

        private List<Student> listStudent = new List<Student>();
        public StudentController() {

            listStudent = new List<Student>
            {
                new Student { Id = 231, Name = "Hoang Quoc Anh", Email = "hqanhh7605@gmail.com", Password = "123", Gender = Gender.Male, Adress = "Nam Dinh", Branch = Branch.IT, IsRegular = true, DateOfBorth = DateTime.ParseExact("07-06-2005","dd-MM-yyyy", null) },

                new Student { Id = 232, Name = "Nhat Linh", Email = "nttl123@gmail.com", Password = "123", Gender = Gender.Female, Adress = "Thai Binh", Branch = Branch.EE, IsRegular = true, DateOfBorth = DateTime.ParseExact("17-07-2005", "dd-MM-yyyy", null) },
                new Student { Id = 233, Name = "Name 3", Email = "name3@gmail.com", Password = "123", Gender = Gender.Male, Adress = "Viet Nam", Branch = Branch.CE, IsRegular = false, DateOfBorth = DateTime.ParseExact("07-12-2005", "dd-MM-yyyy", null) },
                new Student { Id = 234, Name = "Nguyen A", Email = "NguyenA@gmail.com", Password = "123", Gender = Gender.Female, Adress = "Hue", Branch = Branch.BE, IsRegular = false, DateOfBorth = DateTime.ParseExact("15-06-2005", "dd-MM-yyyy", null) },


            };
        }

        public IActionResult Index()
        {
            return View(listStudent);
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {


            return View("Index", student);
        }
    }
}
